using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ExpenseMonitor.Entities;
using System.IO;
using System.Globalization;

namespace ExpenseMonitor.Helpers
{
    public class TabAddExpenseHelper
    {
        public static DataTable getExpenseGridItems()
        {
            DataTable table = new DataTable();
            try
            {
                table = DataManager.getDatatableByExecQuery("SELECT exp.id, expense_date, expense_description, expense_amount, cat.description as description FROM EXPENSES exp, CATEGORY cat where exp.category_id=cat.id ORDER BY exp.expense_date DESC");
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to retrieve expense items from database. \n\n " + exception.ToString());
            }
            return table;
        }

        public static DataTable getExpenseGridItems(DateTime dtFrom, DateTime dtTo, int categoryId, string desc, double amt)
        {
            DateTime dtFromNew = new DateTime(dtFrom.Year, dtFrom.Month, dtFrom.Day, 0, 0, 0);
            DateTime dtToNew = new DateTime(dtTo.Year, dtTo.Month, dtTo.Day, 23, 59, 59);
            DataTable table = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder("SELECT exp.id, expense_date, expense_description, expense_amount, cat.description as description FROM EXPENSES exp, CATEGORY cat WHERE exp.category_id=cat.id ");
                sql.AppendFormat(" AND (expense_date >= '{0}' AND expense_date <='{1}')", dtFromNew, dtToNew);
                
                if (categoryId != -1)
                {
                    sql.AppendFormat(" AND exp.category_id ={0}", categoryId);
                }
                if (desc.Trim().Length>0)
                {
                    sql.AppendFormat(" AND expense_description LIKE '%{0}%'", desc);
                }
                if (amt>0.0)
                {
                    sql.AppendFormat(" AND expense_amount={0}", amt);
                }

                sql.Append(" ORDER BY exp.expense_date DESC");
                table = DataManager.getDatatableByExecQuery(sql.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to retrieve expense items from database. \n\n " + exception.ToString());
            }
            return table;
        }

        public static DataTable getCategories(bool selectRow)
        {
            DataTable catTable = getCategories();
            DataRow row = catTable.NewRow();
            row["id"] = -1;
            row["description"] = "Select a Category";
            
            if (selectRow)
            {
                catTable.Rows.InsertAt(row, 0);
            }
            return catTable;
        }
        
        public static DataTable getCategories()
        {
            DataTable catTable = new DataTable();
            try
            {
                catTable = DataManager.getDatatableByExecQuery("SELECT id, description FROM CATEGORY ORDER BY description ASC");
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to retrieve categories from database. \n\n " + exception.ToString());
            }
            return catTable;
        }

        public static int addExpenseItem(DateTime dt, string desc, double amt, int categoryId)
        {
            try
            {
                StringBuilder str = new StringBuilder("INSERT INTO EXPENSES (expense_date, expense_description, expense_amount, category_id) VALUES ");
                str.AppendFormat("('{0}', '{1}', {2}, {3})", dt.ToString("MM-dd-yyyy"), desc==null?"":desc.Replace("'","''"), amt, categoryId);
                
                return DataManager.execNonQuery(str.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to add expense item into database. \n\n " + exception.ToString());
            }
            return 0;
        }

        public static bool deleteAllExpenses()
        {
            try
            {
                StringBuilder str = new StringBuilder("DELETE FROM EXPENSES");

                return DataManager.execNonQuery(str.ToString()) != 0;
            }
            catch (Exception exception)
            {
                Logger.LogCritical("Unable to all delete expenses from database.");
                Logger.LogException(exception);
            }
            return false;
        }
        
        public static bool deleteExpense(int id)
        {
            try
            {
                StringBuilder str = new StringBuilder("DELETE FROM EXPENSES WHERE id=");
                str.AppendFormat("{0}", id);

                return DataManager.execNonQuery(str.ToString())!=0;
            }
            catch (Exception exception)
            {
                Logger.LogCritical("Unable to delete expense from database.");
                Logger.LogException(exception);
            }
            return false;
        }

        public static List<Expense> getExpenseItemsFromFile(string fileName)
        {
            List<Expense> expenses = new List<Expense>();

            if (File.Exists(fileName))
            {
                string line = "";

                try
                {
                    Logger.LogInfo("Processing input File. Filename=" + fileName);

                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Trim().Length == 0)
                            {
                                //Logger.LogError("Empty line present in file. Ignoring line.");
                                continue;
                            }

                            if (line.Trim().StartsWith("#"))
                            {
                                //Logger.LogError("Comment line found. Ignoring line.");
                                continue;
                            }

                            Expense expense = new Expense();

                            string[] parts = line.Split('\t');

                            if (parts.Length != 4)
                            {
                                Logger.LogError("Invalid line format. It should be date(dd/mm/yyyy),description,category,amount. But the Line is :" + line);
                                continue;
                            }
                            else
                            {
                                if (parts[0] != null && parts[0].Length > 0)
                                {
                                    expense.Date = DateTime.ParseExact(parts[0].Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    string message = "Date cannot be empty. Ignoring line. " + line;
                                    Logger.LogError(message);
                                    continue;
                                }

                                if (parts[1] != null && parts[1].Length > 0)
                                {
                                    expense.Description = parts[1].Trim();
                                }

                                if (parts[2] != null && parts[2].Length > 0)
                                {
                                    expense.Category = parts[2].Trim();
                                }
                                else
                                {
                                    string message = "Category cannot be empty. Ignoring line. " + line;
                                    Logger.LogError(message);
                                    continue;
                                } 
                                
                                if (parts[3] != null && parts[3].Length > 0)
                                {
                                    expense.Amount = double.Parse(parts[3].Trim());
                                }
                                else
                                {
                                    string message = "Amount cannot be empty. Ignoring line. " + line;
                                    Logger.LogError(message);
                                    continue;
                                }
                            }

                            expenses.Add(expense);

                        }
                        reader.Close();
                    }
                }
                catch (Exception exception)
                {
                    Logger.LogError("Unable to process file.");
                    Logger.LogError(line);
                    Logger.LogException(exception);
                }
            }
            else
            {
                Logger.LogError("File does not exist. Filename=" + fileName);
            }

            return expenses;
        }

    }
}
