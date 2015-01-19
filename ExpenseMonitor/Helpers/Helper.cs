using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ExpenseMonitor.Helpers
{
    public class Globals
    {
        public static string ApplicationMode = AppMode.NotSet;
    }

    public class Helper
    {
        public static bool openFolder(string inputFolderName)
        {
            try
            {
                if (!Directory.Exists(inputFolderName))
                {
                    showMessage("Folder does not exists. " + inputFolderName);
                    return false;
                }

                Process.Start(inputFolderName);
            }
            catch (Exception ex)
            {
                string error = "Error launching explorer for folder name " + inputFolderName + "\nException: " + ex.ToString();
                Logger.LogError(error);
                return false;
            }
            return true;
        }

        public static bool editFile(string inputFileName)
        {
            try
            {
                if (!File.Exists(inputFileName))
                {
                    showMessage("Input File does not exists. Select a valid file.");
                    return false;
                }

                Process process = new Process();
                process.StartInfo.FileName = "notepad.exe";
                process.StartInfo.Arguments = inputFileName;
                process.Start();
            }
            catch (Exception ex)
            {
                string error = "Error launching notepad for filename " + inputFileName + "\nException: " + ex.ToString();
                Logger.LogError(error);
                return false;
            }
            return true;
        }

        public static void showMessage(string message)
        {
            MessageBox.Show(message, "Expense Monitor Message");
        }

        public static int getMonthId(string month)
        {
            switch (month)
            {
                case "January":
                    return 1;
                case "February":
                    return 2;
                case "March":
                    return 3;
                case "April":
                    return 4;
                case "May":
                    return 5;
                case "June":
                    return 6;
                case "July":
                    return 7;
                case "August":
                    return 8;
                case "September":
                    return 9;
                case "October":
                    return 10;
                case "November":
                    return 11;
                case "December":
                    return 12;
                default:
                    return 0;
            }
        }    
    }

    public class AppMode
    {
        public static string NotSet = "NotSet";
        public static string Main = "Main";
        public static string SummaryReport = "SummaryReport";
        public static string CategoryReport = "CategoryReport";
        public static string TotalsReport = "TotalsReport";
    }
}
