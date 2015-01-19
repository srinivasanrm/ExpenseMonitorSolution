using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExpenseMonitor.Helpers;
using ExpenseMonitor.Entities;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseMonitor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            try
            {
                loadUI();
            }
            catch (Exception exception)
            {
                Helper.showMessage("Unable to load all values properly. \n\n " + exception.ToString());
            }
        }

        private void loadUI()
        {
            Globals.ApplicationMode = AppMode.Main;

            refreshCategories();
            refreshExpenseGrid();
            clearFindFields();
        }

        private void refreshCategories()
        {
            cmbCategory.DataSource = TabAddExpenseHelper.getCategories(true);
            cmbCategory.DisplayMember = "description";
            cmbCategory.ValueMember = "id";

            cmbCategoryFind.DataSource = TabAddExpenseHelper.getCategories(true);
            cmbCategoryFind.DisplayMember = "description";
            cmbCategoryFind.ValueMember = "id";
        }

        private void refreshExpenseGrid()
        {
            datagridExpense.AutoGenerateColumns = false;
            datagridExpense.DataSource = TabAddExpenseHelper.getExpenseGridItems();
            datagridExpense.Refresh();

            setStatusBarValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveExpense();
        }

        private void saveExpense()
        {
            if (validateAddForm())
            {
                DataRowView row = (DataRowView)cmbCategory.SelectedItem;
                TabAddExpenseHelper.addExpenseItem(dateExpense.Value, txtDesc.Text, double.Parse(txtAmount.Text), int.Parse(row["id"].ToString()));
                refreshExpenseGrid();
            }
        }

        private void clearFields()
        {
            txtAmount.Text = "";
            txtDesc.Text = "";
            cmbCategory.SelectedIndex = 0;
            dateExpense.Value = DateTime.Now;
        }

        private bool validateAddForm()
        {
            if (validateDate(dateExpense))
            {
                return validateAmount(txtAmount);
            }
            return false;
        }

        private bool validateFindForm()
        {
            if (validateDate(dateFindFrom))
            {
                if (validateDate(dateFindTo))
                {
                    if (txtFindAmount.Text.Trim().Length > 0)
                    {
                        return validateAmount(txtFindAmount);
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool validateDate(DateTimePicker date)
        {
            if (date.Value > DateTime.Now)
            {
                Helper.showMessage("Date cannot be in future");
                date.Focus();
                return false;
            }
            return true;
        }

        private bool validateAmount(TextBox amount)
        {
            try
            {
                if (double.Parse(amount.Text) < 1)
                {
                    Helper.showMessage("Amount has to be more than zero.");
                    amount.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Helper.showMessage("Enter a valid amount (example: 123.90)");
                amount.Focus();
                Logger.LogException(ex);
                return false;
            }
            return true;
        }

        private void openCategoryForm()
        {
            frmDescription categoryForm = new frmDescription();
            categoryForm.ShowDialog();
            refreshCategories();
            //refreshExpenseGrid();
        }

        private DataRowView getCurrentSelectedExpenseFromGrid()
        {
            DataRowView row = null;

            if (datagridExpense.RowCount > 0 && datagridExpense.CurrentRow != null && datagridExpense.CurrentRow.DataBoundItem != null)
            {
                if (datagridExpense.CurrentRow.DataBoundItem is DataRowView)
                {
                    row = (DataRowView)datagridExpense.CurrentRow.DataBoundItem;
                }
            }
            return row;
        }

        private void deleteExpense()
        {
            DataRowView row = getCurrentSelectedExpenseFromGrid();
            if (row != null)
            {
                TabAddExpenseHelper.deleteExpense(int.Parse(row["id"].ToString()));
            }
            refreshExpenseGrid();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            openCategoryForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCategoryForm();
        }

        private void expenseGridContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            deleteExpense();
        }

        private void importExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogImportExpense.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                List<Expense> expenses = TabAddExpenseHelper.getExpenseItemsFromFile(openFileDialogImportExpense.FileName);

                foreach (Expense expense in expenses)
                {
                    int categoryId = CategoryHelper.getId(expense.Category);
                    TabAddExpenseHelper.addExpenseItem(expense.Date, expense.Description, expense.Amount, categoryId);
                }
            }
            loadUI();
        }

        private void findExpenses()
        {
            if (validateFindForm())
            {
                double findAmount = 0.0;
                if (txtFindAmount.Text.Trim().Length > 0)
                {
                    findAmount = double.Parse(txtFindAmount.Text);
                }
                DataRowView row = (DataRowView)cmbCategoryFind.SelectedItem;
                DataTable table = TabAddExpenseHelper.getExpenseGridItems(dateFindFrom.Value, dateFindTo.Value, int.Parse(row["id"].ToString()), txtDescFind.Text, findAmount);

                datagridExpense.AutoGenerateColumns = false;
                datagridExpense.DataSource = table;
                datagridExpense.Refresh();

                setStatusBarValues();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            findExpenses();
        }

        private void btnClearFind_Click(object sender, EventArgs e)
        {
            clearFindFields();
            findExpenses();
        }

        private void clearFindFields()
        {
            txtFindAmount.Text = "";
            txtDescFind.Text = "";
            cmbCategoryFind.SelectedIndex = 0;
            dateFindFrom.Value = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 1);
            dateFindTo.Value = DateTime.Now;
        }

        private void setStatusBarValues()
        {
            if (Globals.ApplicationMode == AppMode.Main)
            {
                DataTable table = (DataTable)datagridExpense.DataSource;
                statusLabelRecordCount.Text = "Total Records : " + table.Rows.Count.ToString();
                statusLabelTotalAmount.Text = "Total Amount : " + getTotalAmount(table, "expense_amount").ToString() + "                  ";
            }
            else if (Globals.ApplicationMode == AppMode.SummaryReport)
            {
                DataTable table = (DataTable)dataGridExpenseMonthlyReport.DataSource;
                statusLabelRecordCount.Text = "Total Records : " + table.Rows.Count.ToString();
                statusLabelTotalAmount.Text = "Total Amount : " + getTotalAmount(table, "expense_amount").ToString() + "                  ";
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            saveExpense();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            findExpenses();
        }

        private void btnClearFind_Click_1(object sender, EventArgs e)
        {
            clearFindFields();
            findExpenses();
        }

        private double getTotalAmount(DataTable table, string columnName)
        {
            double amount = 0.0;
            foreach (DataRow row in table.Rows)
            {
                amount = amount + double.Parse(row[columnName].ToString());
            }
            return amount;
        }

        private void btnCreateCategory_Click_1(object sender, EventArgs e)
        {
            openCategoryForm();
        }

        private void tabMain_Enter(object sender, EventArgs e)
        {
            Globals.ApplicationMode = AppMode.Main;

            setStatusBarValues();
        }

        private void tabReports_Enter(object sender, EventArgs e)
        {
            if (!chkMonthlyTabInitialized.Checked)
            {
                initializeMonthlyReportsTab();
            }
            
            if (tabSecondLevel.SelectedTab == tabReportsSummary)
            {
                Globals.ApplicationMode = AppMode.SummaryReport;
            }
           
            setStatusBarValues();
        }

        private void initializeMonthlyReportsTab()
        {
            cmbMonthsMonthlyReport.SelectedItem = DateTime.Now.ToString("MMMM");
            cmbYearsMonthlyReport.SelectedItem = DateTime.Now.ToString("yyyy");

            chkMonthlyTabInitialized.Checked = true;
        }

        private void refreshMonthlyReportsTab()
        {
            DateTime dtStart = DateTime.Now;
            DateTime dtEnd = DateTime.Now;

            if (radioReportsSummaryMonthly.Checked && cmbMonthsMonthlyReport.SelectedItem != null && cmbYearsMonthlyReport.SelectedItem != null)
            {
                int monthStart = Helper.getMonthId(cmbMonthsMonthlyReport.SelectedItem.ToString());
                int yearStart = int.Parse(cmbYearsMonthlyReport.SelectedItem.ToString());

                int monthEnd = monthStart == 12 ? 1 : monthStart + 1;
                int yearEnd = monthStart == 12 ? yearStart + 1 : yearStart;

                dtStart = new DateTime(yearStart, monthStart, 1, 0, 0, 0);
                dtEnd = new DateTime(yearEnd, monthEnd, 1, 0, 0, 0);
            }

            if (radioReportsSummaryLast3.Checked)
            {
                dtStart = dtStart.AddMonths(-3);
            }

            if (radioReportsSummaryLast6.Checked)
            {
                dtStart = dtStart.AddMonths(-6);
            }

//            if (radioReportsSummaryLast9.Checked)
//            {
//                dtStart = dtStart.AddMonths(-9);
//            }

            if (radioReportsSummaryLast12.Checked)
            {
                dtStart = dtStart.AddMonths(-12);
            }

            DataTable table = TabExpenseReportsHelper.getExpenseGridItems(dtStart, dtEnd);
            dataGridExpenseMonthlyReport.AutoGenerateColumns = false;
            dataGridExpenseMonthlyReport.DataSource = table;
            dataGridExpenseMonthlyReport.Refresh();

            DataTable tableTotals = TabExpenseReportsHelper.getTopCategoryTotals(dtStart, dtEnd);
            dataGridCatgTotalsMonthlyReport.AutoGenerateColumns = false;
            dataGridCatgTotalsMonthlyReport.DataSource = tableTotals;
            dataGridCatgTotalsMonthlyReport.Refresh();
            refreshChartSummary(tableTotals);

            setStatusBarValues();
        }

        private void refreshChartSummary(DataTable table)
        {
            chartSummary.DataSource = TabExpenseReportsHelper.getTopCategoryTotals(table, 7);

            chartSummary.Series["Series1"].ChartType = SeriesChartType.Pie;
            chartSummary.Series["Series1"].XValueMember = "category";
            chartSummary.Series["Series1"].YValueMembers = "total";
            chartSummary.Series["Series1"].IsValueShownAsLabel = true;
            chartSummary.Series["Series1"].IsVisibleInLegend = true;
//            chartSummary.Series["Series1"]["PieLabelStyle"] = "Outside";
            chartSummary.Series["Series1"].BorderWidth = 1;
            chartSummary.Series["Series1"].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);
            chartSummary.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartSummary.DataManipulator.Sort(PointSortOrder.Descending, chartSummary.Series[0]);
            chartSummary.DataBind();
        }

        private void cmbMonthsMonthlyReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectReportsSummaryMonthlyRadio();
            refreshMonthlyReportsTab();
        }

        private void cmbYearsMonthlyReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectReportsSummaryMonthlyRadio();
            refreshMonthlyReportsTab();
        }

        private void selectReportsSummaryMonthlyRadio()
        {
            radioReportsSummaryMonthly.Checked = true;
        }

        private void btnNextMonthlyReports_Click(object sender, EventArgs e)
        {
            selectReportsSummaryMonthlyRadio();

            int nextItem = cmbMonthsMonthlyReport.SelectedIndex + 1;

            if (nextItem == 12)
            {
                nextItem = 11;
            }
            cmbMonthsMonthlyReport.SelectedItem = cmbMonthsMonthlyReport.Items[nextItem];
        }

        private void btnPrevMonthlyReports_Click(object sender, EventArgs e)
        {
            selectReportsSummaryMonthlyRadio();

            int prevItem = cmbMonthsMonthlyReport.SelectedIndex - 1;

            if (prevItem == -1)
            {
                prevItem = 0;
            }
            cmbMonthsMonthlyReport.SelectedItem = cmbMonthsMonthlyReport.Items[prevItem];
        }

        private void radioReportsSummaryMonthly_CheckedChanged(object sender, EventArgs e)
        {
            refreshMonthlyReportsTab();
        }

        private void radioReportsSummaryLast3_CheckedChanged(object sender, EventArgs e)
        {
            refreshMonthlyReportsTab();
        }

        private void radioReportsSummaryLast6_CheckedChanged(object sender, EventArgs e)
        {
            refreshMonthlyReportsTab();
        }

        private void radioReportsSummaryLast9_CheckedChanged(object sender, EventArgs e)
        {
            refreshMonthlyReportsTab();
        }

        private void radioReportsSummaryLast12_CheckedChanged(object sender, EventArgs e)
        {
            refreshMonthlyReportsTab();
        }

        private void openRecentLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Logger.Instance().Filename))
            {
                Helper.editFile(Logger.Instance().Filename);
            }
            else
            {
                DialogResult result = MessageBox.Show("No log files created yet for today. Do you want to open log folder?", "RAWC Message", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    Helper.openFolder((new FileInfo(Logger.Instance().Filename)).DirectoryName);
                }
            }
        }

        private void exportExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportExpenseItems();
        }

        private void exportExpenseItems()
        {
            DialogResult result = exportFileDialog.ShowDialog();
            string exportFileName = exportFileDialog.FileName;
            string line = "";

            try
            {
                DataTable table = (DataTable)datagridExpense.DataSource;

                using (StreamWriter writer = new StreamWriter(exportFileName))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["expense_date"] != null && row["expense_description"] != null && row["expense_amount"] != null && row["description"] != null)
                        {
                            DateTime expenseDate = DateTime.Parse(row["expense_date"].ToString());
                            string desc = row["expense_description"].ToString();
                            double amount = double.Parse(row["expense_amount"].ToString());
                            string category = row["description"].ToString();

                            line = String.Format("{0}\t{1}\t{2}\t{3}",
                                        expenseDate.ToString("dd/MM/yyyy"),
                                        desc,
                                        category,
                                        amount);
                            writer.WriteLine(line);
                        }
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Helper.showMessage("Unable to export expense items into the file. See log file for more information");
                Logger.LogError("Error exporting. Line=" + line); 
                Logger.LogException(ex);
            }
        }
    }
}