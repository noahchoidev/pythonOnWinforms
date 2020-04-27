using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pythonOnWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmd = cmdTextBox.Text;
            var args = argsTextBox.Text;

            args = @"C:\Users\ggusa\Desktop\Test_py1\nav_ex_1.py"; //hello.py 

            ProcessStartInfo start = new ProcessStartInfo() // fileName => .exe , argument => .py
            {
                FileName = @"C:\Users\ggusa\anaconda3\python.exe", // "my/full/path/to/python.exe";
                Arguments = args, // string.Format("{0} {1}", cmd, args),
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    process.WaitForExit();
                    Console.Write(result);

                    ResultLabel.Text = result;
                }
            }
        }

        private void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo() 
            {
                FileName= @"C:\Users\ggusa\anaconda3\python.exe", // "my/full/path/to/python.exe";
                Arguments = string.Format("{0} {1}", cmd, args),
                UseShellExecute =false,
                RedirectStandardOutput=true,
            };

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}
