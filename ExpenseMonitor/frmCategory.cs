using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExpenseMonitor.Helpers;

namespace ExpenseMonitor
{
    public partial class frmDescription : Form
    {
        public frmDescription()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        
            try 
            {
                loadUI();
            }
            catch(Exception exception)
            {
                Helper.showMessage("Unable to load all values properly. \n\n " + exception.ToString());
            }
        }

        private void loadUI()
        {
            refreshCategories();
        }

        private void refreshCategories()
        {
            try
            {
                datagridCategories.AutoGenerateColumns = false;
                datagridCategories.DataSource = CategoryHelper.getCategories();
                datagridCategories.Refresh();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                Helper.showMessage("Categories could not retrieved from database");
            }
        }

        private void datagridCategories_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView row = getCurrentSelectedCategoryFromGrid();
            
            if ( row!=null )
            {
                txtCategory.Text = row["description"].ToString();
            }
        }

        private bool deleteCategory()
        {
            DataRowView row = getCurrentSelectedCategoryFromGrid();

            if (row != null)
            {
                if (CategoryHelper.deleteCategory(row["description"].ToString())==0)
                {
                    return false;
                }
            }

            return true;
        }

        private DataRowView getCurrentSelectedCategoryFromGrid()
        {
            DataRowView row = null;

            if (datagridCategories.RowCount > 0 && datagridCategories.CurrentRow != null && datagridCategories.CurrentRow.DataBoundItem != null)
            {
                if (datagridCategories.CurrentRow.DataBoundItem is DataRowView)
                {
                    row = (DataRowView)datagridCategories.CurrentRow.DataBoundItem;
                }
            }
            return row;
        }

        private void addCategory()
        {
            if (validateForm())
            {
                if (CategoryHelper.checkAndAddCategory(txtCategory.Text))
                {
                    refreshCategories();
                }
                else
                {
                    Helper.showMessage("Category exists already");
                    txtCategory.Focus();
                }
            }            
        }

        private bool validateForm()
        {
            if (txtCategory.Text.Trim().Length < 1)
            {
                Helper.showMessage("Category Name is required");
                txtCategory.Focus();
                return false;
            } 
            return true;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyCategory();
        }

        private bool modifyCategory()
        {
            if (validateForm())
            {
                DataRowView row = getCurrentSelectedCategoryFromGrid();

                if (row == null)
                {
                    Helper.showMessage("Select a category to modify");
                    return false;
                }
                else
                {
                    int id = int.Parse(row["id"].ToString());
                    if (CategoryHelper.modifyCategory(txtCategory.Text, id))
                    {
                        refreshCategories();
                        return true;
                    }
                    else 
                    {
                        Helper.showMessage("Unable to modify category");
                    }
                }
            }
            return false;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the category?", "Expense Monitor Message", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (!deleteCategory())
                {
                    Helper.showMessage("Category could not be deleted as this category is used in some Expense item");
                }
            }
            refreshCategories();
        }

    }
}
