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

        
        string logFolder = Environment.CurrentDirectory + @"\log";

        

        private string getDate()
        {
            if (!Directory.Exists(logFolder + @"\" + DateTime.Today.ToShortDateString())) Directory.CreateDirectory(logFolder + @"\" + DateTime.Today.ToShortDateString());
            return DateTime.Today.ToShortDateString();

        }

       
        
        
        public void Debug(string message)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder+ @"\" + getDate()+@"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Debug(string message, Exception e)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void DebugFormat(string message, params object[] args)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Debug.txt", true);
            sw.WriteLine(dateNow + " : " + message + args);
            sw.Close();
        }

        public void Error(string message)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Error.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Error(string message, Exception e)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Error.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void Error(Exception ex)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Error.txt", true);
            sw.WriteLine(dateNow + " : " + ex.ToString());
            sw.Close();

        }

        public void ErrorUnique(string message, Exception e)
        {
            string Path = logFolder + @"\" + getDate() + @"\ErrorUnique.txt";
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
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Fatal.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Fatal(string message, Exception e)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Fatal.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void Info(string message)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Info.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Info(string message, Exception e)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Info.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void Info(string message, params object[] args)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Info.txt", true);
            sw.WriteLine(dateNow + " : " + message + args);
            sw.Close();
        }

        public void SystemInfo(string message, Dictionary<object, object> properties = null)
        {
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\SystemInfo.txt", true);
            sw.WriteLine(dateNow + " : " + message + properties.ToString());
            sw.Close();
        }

        public void Warning(string message)
        {
            
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Warning.txt", true);
            sw.WriteLine(dateNow + " : " + message);
            sw.Close();
        }

        public void Warning(string message, Exception e)
        {
            
            string dateNow = DateTime.Now.ToString();

            StreamWriter sw = new StreamWriter(logFolder + @"\" + getDate() + @"\Warning.txt", true);
            sw.WriteLine(dateNow + " : " + message + e.ToString());
            sw.Close();
        }

        public void WarningUnique(string message)
        {
             string Path = logFolder + @"\" + getDate() + @"\WarningUnique.txt";
            
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
