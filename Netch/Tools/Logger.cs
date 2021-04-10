using System;
using System.Diagnostics;
using System.IO;

namespace Netch.Tools
{
    public class Logger
    {
        /// <summary>
        ///     保存路径
        /// </summary>
        public string SavePath;

        /// <summary>
        ///     互斥锁
        /// </summary>
        private object mutex = new object();

        /// <summary>
        ///     写入日志
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        private void WriteLine(string name, string text)
        {
            var method = new StackTrace().GetFrame(2).GetMethod();

            lock (mutex)
            {
                File.AppendAllText(this.SavePath, $"[{DateTime.Now}][{method.ReflectedType.Name}.{method.Name}][{name}] {text}\n");
            }
        }

        /// <summary>
        ///     调试
        /// </summary>
        /// <param name="text"></param>
        public void Debug(string text)
        {
            this.WriteLine("DEBUG", text);
        }

        /// <summary>
        ///     信息
        /// </summary>
        /// <param name="text"></param>
        public void Info(string text)
        {
            this.WriteLine("INFO", text);
        }

        /// <summary>
        ///     警告
        /// </summary>
        /// <param name="text"></param>
        public void Warning(string text)
        {
            this.WriteLine("WARNING", text);
        }

        /// <summary>
        ///     错误
        /// </summary>
        /// <param name="text"></param>
        public void Error(string text)
        {
            this.WriteLine("ERROR", text);
        }

        /// <summary>
        ///     崩溃
        /// </summary>
        /// <param name="text"></param>
        public void Fatal(string text)
        {
            this.WriteLine("FATAL", text);
        }
    }
}
