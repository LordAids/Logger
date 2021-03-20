using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Logger : ILog
    {
        string dateNow = DateTime.Now.ToString();
        string logFolder = Environment.CurrentDirectory + @"\log";
        public void Debug(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();            

            if (!Directory.Exists(logFolder + @"\" + dateDay)) Directory.CreateDirectory(logFolder + @"\" + dateDay);

            StreamWriter sw = new StreamWriter(logFolder+ @"\" + dateDay+@"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Debug(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();

            if (!Directory.Exists(logFolder + @"\" + dateDay)) Directory.CreateDirectory(logFolder + @"\" + dateDay);

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void DebugFormat(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception e)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void ErrorUnique(string message, Exception e)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception e)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, Exception e)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void SystemInfo(string message, Dictionary<object, object> properties = null)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, Exception e)
        {
            throw new NotImplementedException();
        }

        public void WarningUnique(string message)
        {
            throw new NotImplementedException();
        }
    }
}
