using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ExpenseMonitor.Helpers
{
    public class CategoryHelper
    {
        public static DataTable getCategories()
        {
            DataTable catTable = new DataTable();
            catTable = DataManager.getDatatableByExecQuery("SELECT id, description FROM CATEGORY ORDER BY description ASC");
            return catTable;
        }

        public static int getId(string category)
        {
            string sql = "SELECT id from CATEGORY WHERE description='" + category + "'";

            DataTable table = DataManager.getDatatableByExecQuery(sql);

            if ( table.Rows.Count>0 )
            {
                return int.Parse(table.Rows[0]["id"].ToString());
            }
            else
            {
                addCategory(category);
                return getId(category);
            }
        }
        
        public static bool checkAndAddCategory(string category)
        {
            string sql = "SELECT 1 from CATEGORY WHERE description='" + category + "'";

            if (DataManager.doesRowExists(sql))
            {
                return false;
            }
            else
            {
                addCategory(category);
            }
            return true;
        }

        public static bool modifyCategory(string category, int id)
        {
            try
            {
                StringBuilder str = new StringBuilder("UPDATE CATEGORY SET description=");
                str.AppendFormat("('{0}')", category.Replace("'", "''"));
                str.AppendFormat(" WHERE id={0}", id);

                return DataManager.execNonQuery(str.ToString())>0;
            }
            catch (Exception exception)
            {
                Logger.LogCritical("Unable to modify category in database. \n\n " + exception.ToString());
            }
            return false;
        }
        
        public static int addCategory(string category)
        {
            try
            {
                StringBuilder str = new StringBuilder("INSERT INTO CATEGORY (description) VALUES ");
                str.AppendFormat("('{0}')", category.Replace("'", "''"));
                
                return DataManager.execNonQuery(str.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogCritical("Unable to add category into database. \n\n " + exception.ToString());
            }
            return 0;
        }

        public static int deleteCategory(string category)
        {
            try
            {
                StringBuilder str = new StringBuilder("DELETE FROM CATEGORY WHERE description=");
                str.AppendFormat("'{0}'", category);

                return DataManager.execNonQuery(str.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogCritical("Unable to delete category from database. \n\n " + exception.ToString());
            }
            return 0;
        }
        
        public static int deleteAllCategories()
        {
            try
            {
                StringBuilder str = new StringBuilder("DELETE FROM CATEGORY");

                return DataManager.execNonQuery(str.ToString());
            }
            catch (Exception exception)
            {
                Logger.LogCritical("Unable to delete all categories from database. \n\n " + exception.ToString());
            }
            return 0;
        }
    }
}
