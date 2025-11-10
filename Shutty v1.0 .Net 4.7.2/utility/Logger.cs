using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utility
{
    public static class Logger
    {
        public static List<string> History = new List<string>();

        public static void Add(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            History.Add($"[{timestamp}] {message}");
        }

        public static void Clear()
        {
            History.Clear();
        }
    }
}
