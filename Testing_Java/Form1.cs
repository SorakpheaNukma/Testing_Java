//code edited by Mao Sorakpheanukma
//Giao vien huong dan: Do Duy Cop
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Java
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "\"C:\\Program Files\\Java\\jdk-20\\bin\\java.exe\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.WorkingDirectory = Application.StartupPath;
            startInfo.Arguments = $"nukma {textBox1.Text} {textBox2.Text}";
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    while (!exeProcess.StandardOutput.EndOfStream)
                    {
                        string line = exeProcess.StandardOutput.ReadLine();
                        // do something with line
                        txtKQ.AppendText(line + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                txtKQ.AppendText($"ERROR: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
