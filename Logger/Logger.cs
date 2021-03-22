using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger : ILog
    {

        string dateDay = DateTime.Today.ToShortDateString();
        string logFolder = Environment.CurrentDirectory + @"\log";

        public Logger()
        {
            if (!Directory.Exists(logFolder + @"\" + dateDay)) Directory.CreateDirectory(logFolder + @"\" + dateDay);
        }
        
        
        public void Debug(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder+ @"\" + dateDay+@"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Debug(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void DebugFormat(string message, params object[] args)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message + args);
            sw.Close();
        }

        public void Error(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Error.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Error(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Error.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void Error(Exception ex)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Error.txt", true);
            sw.WriteLine(dateNow + " : " + ex.ToString());
            sw.Close();

        }

        public void ErrorUnique(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string Path = logFolder + @"\" + dateDay + @"\ErrorUnique.txt";
            if (File.Exists(Path)) 
             {
                string Errors = File.ReadAllText(Path);
                message += " " + e.ToString();

                if (!Errors.Contains(message)) //проверка наличия записи об ошибке
                {
                    StreamWriter sw = new StreamWriter(Path, true);
                    sw.WriteLine(message);
                    sw.Close();
                }
            } else
            {
                StreamWriter sw = new StreamWriter(Path, true);
                sw.WriteLine(message);
                sw.Close();
            }
            

        }

        public void Fatal(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Fatal.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Fatal(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Fatal.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void Info(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Info.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Info(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Info.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void Info(string message, params object[] args)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Info.txt", true);
            sw.WriteLine(dateNow + " : " + message + args);
            sw.Close();
        }

        public void SystemInfo(string message, Dictionary<object, object> properties = null)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\SystemInfo.txt", true);
            sw.WriteLine(dateNow + " : " + message + properties.ToString());
            sw.Close();
        }

        public void Warning(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Warning.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Warning(string message, Exception e)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + dateDay + @"\Warning.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void WarningUnique(string message)
        {
            string dateDay = DateTime.Today.ToShortDateString();
            string Path = logFolder + @"\" + dateDay + @"\WarningUnique.txt";
            
            if (File.Exists(Path))
            {
                string Warnings = File.ReadAllText(Path);
                if (Warnings.IndexOf(message) == -1) //проверка наличия записи об ошибке
                {
                    StreamWriter sw = new StreamWriter(Path, true);
                    sw.WriteLine(message);
                    sw.Close();
                }
            } else
            {
                StreamWriter sw = new StreamWriter(Path, true);
                sw.WriteLine(message);
                sw.Close();
            }
        }
    }
}
