using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace hwlesson_2
{
    public partial class Form1 : Form
    {
        private Process childProcess;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                childProcess = new Process();
                childProcess.StartInfo.FileName = "notepad.exe";

                childProcess.EnableRaisingEvents = true;

                childProcess.Exited += ChildProcess_Exited;

                childProcess.Start();

                lblProcessName.Text = $"Name: {childProcess.ProcessName}";
                lblProcessId.Text = $"Process ID: {childProcess.Id}";
                lblExitCode.Text = "Status: Running...";

                btnStart.Enabled = false;
                btnKill.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Launch error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChildProcess_Exited(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ChildProcess_Exited(sender, e)));
                return;
            }

            try
            {
                int exitCode = childProcess.ExitCode;
                lblExitCode.Text = $"Exit Code: {exitCode}";
            }
            catch (Exception)
            {
                lblExitCode.Text = "Process terminated forcefully.";
            }
            finally
            {
                btnStart.Enabled = true;
                btnKill.Enabled = false;
                childProcess?.Dispose();
                childProcess = null;
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (childProcess != null && !childProcess.HasExited)
            {
                try
                {
                    childProcess.Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to terminate process: {ex.Message}");
                }
            }
        }
    }
}