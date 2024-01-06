using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Database
    {
        public string databaseId { get; set; }
        public string eTag;
    }
}

/*using System;
using System.Diagnostics;
using System.ComponentModel;

namespace MyProcessSample
{
    class MyProcess
    {
        void BindToRunningProcesses()
        {
            // Get the current process.
            Process currentProcess = Process.GetCurrentProcess();

            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcesses();

            // Get all instances of Notepad running on the local computer.
            // This will return an empty array if notepad isn't running.
            Process[] localByName = Process.GetProcessesByName("Microsoft Azure Cosmos Emulator");
        }
        static void Main()
        {
            MyProcess myProcess = new MyProcess();
            myProcess.BindToRunningProcesses();
        }
    }
}*/