using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ExpenseMonitor.Helpers
{
    public class TabExpenseReportsHelper
    {
        public static DataTable getExpenseGridItems(DateTime dtFromNew, DateTime dtToNew)
        {
            DataTable table = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder("SELECT exp.id, expense_date, expense_description, expense_amount, cat.description as description FROM EXPENSES exp, CATEGORY cat WHERE exp.category_id=cat.id ");
                sql.AppendFormat(" AND (expense_date >= '{0}' AND expense_date <'{1}')", dtFromNew, dtToNew);
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
        
        public static DataTable getTopCategoryTotals(DateTime dtFromNew, DateTime dtToNew)
        {
            DataTable table = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder("SELECT cat.description as category, sum(exp.expense_amount) as total FROM EXPENSES exp, CATEGORY cat WHERE exp.category_id=cat.id ");
                sql.AppendFormat(" AND (expense_date >= '{0}' AND expense_date <'{1}')", dtFromNew, dtToNew);
                sql.Append(" GROUP BY cat.description");
                sql.Append(" ORDER BY total DESC");
                table = DataManager.getDatatableByExecQuery(sql.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to retrieve expense items from database. \n\n " + exception.ToString());
            }
            return table;
        }

        public static DataTable getTopCategoryTotals(DataTable inputTable, int topRowsCount)
        {
            DataTable table = inputTable.Copy();
            table.Clear();
            double otherTotal = 0;
            try
            {
                for (int i = 0; i < inputTable.Rows.Count; i++)
                {
                    if (i > topRowsCount - 1)
                    {
                        otherTotal = otherTotal + double.Parse(inputTable.Rows[i]["total"].ToString());
                    }
                    else 
                    {
                        table.Rows.Add(inputTable.Rows[i][0], inputTable.Rows[i][1]);
                    }
                }
                if (inputTable.Rows.Count>5)
                {
                    table.Rows.Add("Other", otherTotal);
                }
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to trim top category totals from database. \n\n " + exception.ToString());
            }
            return table;
        }
        
        public static DataTable getMonthlyTotal()
        {
            DataTable table = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder("select datepart(month, expense_date), category_id as category, sum(expense_amount) as total FROM EXPENSES exp ");
                sql.Append(" GROUP BY datepart(month, expense_date) , category_id");
                table = DataManager.getDatatableByExecQuery(sql.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                Helper.showMessage("Unable to retrieve expense items from database. \n\n " + exception.ToString());
            }
            return table;
        }

    }
}
