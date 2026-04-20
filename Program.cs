using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility
{
    internal static class Program
    {
        public static int time;

        private const string MutexName = "ShuttyUtility_SingleInstance_Mutex";

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        [STAThread]
        static void Main()
        {
            bool createdNew;

            using (Mutex mutex = new Mutex(true, MutexName, out createdNew))
            {
                if (!createdNew)
                {
                    ActivateExistingInstance();
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
        private static void ActivateExistingInstance()
        {
            var current = Process.GetCurrentProcess();

            var currentId = current.Id;

            string currentProcessName = current.ProcessName;

            foreach (Process process in Process.GetProcessesByName(currentProcessName))
            {
                if (process.Id != currentId &&
                    process.MainWindowHandle != IntPtr.Zero)
                {
                    ShowWindow(process.MainWindowHandle, SW_RESTORE);
                    SetForegroundWindow(process.MainWindowHandle);
                    break;
                }
            }
        }
        public static async Task ShutDownPc()
        {
            using var process = new Process();
            int seconds = time * 60;

            process.StartInfo.FileName = "shutdown.exe";
            process.StartInfo.Arguments = $"/s /t {seconds}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            Logger.Add($"PC shutdown in {Program.time} min!");
            await Task.Delay(3000);
            process.Start();
        }
        public static async Task RestartPc()
        {
            var process = new Process();
            int seconds = time * 60;

            process.StartInfo.FileName = "shutdown.exe";
            process.StartInfo.Arguments = $"/r /t {seconds}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            Logger.Add($"PC restart in {Program.time} min!");
            await Task.Delay(3000);
            process.Start();
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
                process.WaitForExit();

                if (process.ExitCode == 0)

                    Logger.Add("Undo operation!");
                else
                    Logger.Add("No operation to undo");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}