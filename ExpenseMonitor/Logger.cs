using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace ExpenseMonitor
{
    public class Logger
    {
        public enum LogLevel
        {
            CRITICAL = 1,
            ERROR = 2,
            WARNING = 3,
            INFO = 4,
            DEBUG = 5
        }

        private static Logger _instance = null;

        private string _filename;
        private bool _append;
        private bool _toConsole;
        private LogLevel _level;
        private bool _enabled;
        private StreamWriter _streamWriter;
        private const string MMDDYY = "MMddyy";//month-day-year

        public Logger()
        {
            _filename = null;
            _append = true;
            _toConsole = false;
            _enabled = true;
            _level = LogLevel.DEBUG;
        }

        public static Logger Instance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public LogLevel Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public string Filename
        {
            get
            {
                if (_filename == null)
                {
                    _filename = ConstructNewFileName();
                }
                return _filename;
            }
            set
            {
                string newValue = (value == null) ? "" : value;
                if (_filename != newValue)
                {
                    Close();
                    _filename = newValue;
                }
            }
        }

        public bool Append
        {
            get { return _append; }
            set { _append = value; }

        }

        public bool ToConsole
        {
            get { return _toConsole; }
            set { _toConsole = value; }
        }

        //return null if there is no need for a new file name (which means we are still in the same day as the current log file's creation day)
        private string GetNewFileName()
        {
            if (_filename == null || IsOldFile(_filename))
            {
                return ConstructNewFileName();
            }
            else
            {
                return null;
            }
        }

        private bool IsOldFile(string fileName)
        {
            return (fileName.IndexOf(DateTime.Now.ToString(MMDDYY)) == -1);
        }

        private string ConstructNewFileName()
        {
            if (!Directory.Exists("temp"))
            {
                Directory.CreateDirectory("temp");
            }

            string logs = "temp\\logs";

            if (!Directory.Exists(logs) )
            {
                Directory.CreateDirectory(logs);
            }

            return logs + "/Application_" + DateTime.Now.ToString(MMDDYY) + ".log";
        }

        public void Init()
        {
            string newFileName = GetNewFileName();
            if (newFileName != null)
            {
                Filename = newFileName;
                DeleteOldFiles();
            }

            if (_streamWriter == null)
            {
                lock (this)
                {
                    if (_streamWriter == null && Filename != "")
                    {
                        try
                        {
                            _streamWriter = new StreamWriter(Filename, Append);
                            _streamWriter.AutoFlush = true;
                            LogInfo("Begin Log.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                            Console.WriteLine("Exception initializing log to : " +
                                Filename + ". Using console. ");
                            _streamWriter = null;
                            ToConsole = true;
                        }
                    }
                }
            }
        }

        public void Close()
        {
            lock (this)
            {
                if (_streamWriter != null)
                {
                    _streamWriter.WriteLine("[" + DateTime.Now.ToString("G") + "] " + "End Log");
                    _streamWriter.Flush();
                    _streamWriter.Close();
                    _streamWriter = null;
                }
            }
        }

        private void DeleteOldFiles()
        {
            FileInfo currFile = new FileInfo(Filename);
            FileInfo[] currFiles = currFile.Directory.GetFiles();

            foreach (FileInfo currFileInfo in currFiles)
            {
                if (currFileInfo.LastWriteTime < DateTime.Now.AddDays(-5))//delete files which are more than 7 days old
                {
                    try
                    {
                        currFileInfo.Delete();
                    }
                    catch (Exception ex)
                    {
                        LogCritical(string.Format("Unable to delete the old log file <{0}>. Maybe the file is still in use.", currFileInfo.FullName));
                        LogCritical(ex.ToString());
                    }
                }
            }
        }

        public void LogLine(string text)
        {
            if (Enabled)
            {
                Init();
                string message = "[" + DateTime.Now.ToString("G") + "] " + text;
                lock (this)
                {
                    if (_streamWriter != null)
                    {
                        _streamWriter.WriteLine(message);
                    }
                    if (_toConsole || _streamWriter == null)
                    {
                        Console.WriteLine(message);
                    }
                }
            }
        }

        public void LogMessage(LogLevel level, string text)
        {
            if (level <= Level)
            {
                string message = "[" + level.ToString().ToLower() + "] " + text;
                LogLine(message);
            }
        }

        public static void LogDebug(string text)
        {
            Logger.Instance().LogMessage(LogLevel.DEBUG, text);
        }

        public static void LogInfo(string text)
        {
            Logger.Instance().LogMessage(LogLevel.INFO, text);
        }

        public static void LogWarning(string text)
        {
            Logger.Instance().LogMessage(LogLevel.WARNING, text);
        }

        public static void LogError(string text)
        {
            Logger.Instance().LogMessage(LogLevel.ERROR, text);
        }

        public static void LogCritical(string text)
        {
            Logger.Instance().LogMessage(LogLevel.CRITICAL, text);
        }

        public static void LogException(Exception ex)
        {
            Logger.Instance().LogMessage(LogLevel.ERROR, ex.ToString());
        }
    }
}
