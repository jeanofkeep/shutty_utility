using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace utility
{
    internal static class Program
    {
        public static int time;
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void ShutDownPc()
        {

            var process = new Process();

            int seconds = time * 60; 

            process.StartInfo.FileName = "shutdown.exe";
            process.StartInfo.Arguments = $"/s /t {seconds}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            Logger.Add($"PC shutdown in {Program.time} min!");

            //Console.WriteLine($"Выключаем через {time} минут");
            //Thread.Sleep(5000);
            //process.Kill();
        }

        public static void RestartPc()
        {
            var process = new Process();

            int seconds = time * 60;

            process.StartInfo.FileName = "shutdown.exe";
            process.StartInfo.Arguments = $"/r /t {seconds}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            Logger.Add($"PC restart in {Program.time} min!");

            //Console.WriteLine($"Restart in {time} min.");
        }
        public static void Undo()
        {
            try
            {
                var process = new Process();

                process.StartInfo.FileName = "shutdown.exe";
                process.StartInfo.Arguments = "/a";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                Logger.Add("Undo operation!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error undo");
            }
        }

        

    }
}
