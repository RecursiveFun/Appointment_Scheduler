using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Appointment_Scheduler_Felix_Berinde
{

    //Code referenced from https://stackoverflow.com/questions/20185015/how-to-write-log-file-in-c
    //for this function
    public static class LogWriter
    {
        private static string m_exePath = string.Empty;

        public static void LogWrite(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter write = File.AppendText(m_exePath + "\\" + "UserLoginLog.txt"))
                {
                    Log(logMessage, write);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logging error. ", ex.ToString());
            }
        }

        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  {0}", logMessage);
                txtWriter.WriteLine("-------------------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logging error. ", ex.ToString());
            }
        }
    }
}

