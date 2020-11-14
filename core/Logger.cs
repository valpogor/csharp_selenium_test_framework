using System;
using System.IO;
using System.Text;

namespace Selenium.core
{
    public static class Logger
    {
        public static StringBuilder LogString = new StringBuilder();
        public static void WriteLine(string str)
        {
            Console.WriteLine(str);
            LogString.Append(str).Append(Environment.NewLine);
        }
        public static void Write(string str)
        {
            Console.Write(str);
            LogString.Append(str);

        }
        public static void SaveLog(bool Append = false)
        {
            var dirName = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
            var fileInfo = new FileInfo(dirName);
            var parentDirName = fileInfo?.FullName;
            var path = parentDirName + @"\libs\Log.txt";

            if (LogString != null && LogString.Length > 0)
            {
                if (Append)
                {
                    using (StreamWriter file = System.IO.File.AppendText(path))
                    {
                        file.Write(LogString.ToString());
                        file.Close();
                        file.Dispose();
                    }
                }
                else
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
                    {
                        file.Write(LogString.ToString());
                        file.Close();
                        file.Dispose();
                    }
                }
            }
        }
    }
}
