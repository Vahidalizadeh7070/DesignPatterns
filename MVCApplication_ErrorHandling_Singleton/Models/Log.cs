using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace MVCApplication_ErrorHandling.Models
{
    // We use sealed keyword due to the using of private Log constructor
    public sealed class Log : ILog
    {
        // private constructor
        private Log()
        { 

        }

        // Singleton design pattern to create and instance from Log class
        private static readonly Lazy<Log> instance = new Lazy<Log>(()=>new Log());
        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        // This method handle the log exception
        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1},Log","Exception",Guid.NewGuid().ToString());
            string logFilePath = string.Format(@"{0}\{1}",AppDomain.CurrentDomain.BaseDirectory,fileName);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("-------");
            stringBuilder.AppendLine(DateTime.Now.ToString());
            stringBuilder.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath,true))
            {
                writer.Write(stringBuilder.ToString());
                writer.Flush();
            }
        }
    }
}