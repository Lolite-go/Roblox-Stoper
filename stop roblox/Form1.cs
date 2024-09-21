using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace stop_roblox
{
    public partial class Form1 : Form
    {
        // Import Windows API functions for suspending and resuming processes
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll")]
        private static extern uint SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hObject);

        // Constants for thread access
        const int THREAD_SUSPEND_RESUME = 0x0002;

        // Timer for checking process status
        private Timer processCheckTimer;

        public Form1()
        {
            InitializeComponent();

            // Set up Timer to check process status every second
            processCheckTimer = new Timer();
            processCheckTimer.Interval = 1000; // 1000ms = 1 second
            processCheckTimer.Tick += ProcessCheckTimer_Tick;
            processCheckTimer.Start();
        }

        // Method to check process status
        private void ProcessCheckTimer_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length > 0)
            {
                labelStatus.Text = "Status: Process is running";
                labelStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelStatus.Text = "Status: Process not found";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            // Suspend the RobloxPlayerBeta process
            var processes = Process.GetProcessesByName("RobloxPlayerBeta");
            foreach (var process in processes)
            {
                foreach (ProcessThread thread in process.Threads)
                {
                    IntPtr pOpenThread = OpenThread(THREAD_SUSPEND_RESUME, false, (uint)thread.Id);
                    if (pOpenThread == IntPtr.Zero)
                    {
                        continue;
                    }
                    SuspendThread(pOpenThread);
                    CloseHandle(pOpenThread);
                }
            }
            MessageBox.Show("RobloxPlayerBeta has been suspended.");
        }

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            // Resume the RobloxPlayerBeta process
            var processes = Process.GetProcessesByName("RobloxPlayerBeta");
            foreach (var process in processes)
            {
                foreach (ProcessThread thread in process.Threads)
                {
                    IntPtr pOpenThread = OpenThread(THREAD_SUSPEND_RESUME, false, (uint)thread.Id);
                    if (pOpenThread == IntPtr.Zero)
                    {
                        continue;
                    }
                    ResumeThread(pOpenThread);
                    CloseHandle(pOpenThread);
                }
            }
            MessageBox.Show("RobloxPlayerBeta has been resumed.");
        }
    }
}
