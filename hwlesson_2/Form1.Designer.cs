namespace hwlesson_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.lblProcessId = new System.Windows.Forms.Label();
            this.lblExitCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnKill
            // 
            this.btnKill.Enabled = false;
            this.btnKill.Location = new System.Drawing.Point(200, 30);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(150, 40);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Kill Process";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(30, 95);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(53, 17);
            this.lblProcessName.TabIndex = 2;
            this.lblProcessName.Text = "Name: -";
            // 
            // lblProcessId
            // 
            this.lblProcessId.AutoSize = true;
            this.lblProcessId.Location = new System.Drawing.Point(30, 130);
            this.lblProcessId.Name = "lblProcessId";
            this.lblProcessId.Size = new System.Drawing.Size(90, 17);
            this.lblProcessId.TabIndex = 3;
            this.lblProcessId.Text = "Process ID: -";
            // 
            // lblExitCode
            // 
            this.lblExitCode.AutoSize = true;
            this.lblExitCode.Location = new System.Drawing.Point(30, 165);
            this.lblExitCode.Name = "lblExitCode";
            this.lblExitCode.Size = new System.Drawing.Size(65, 17);
            this.lblExitCode.TabIndex = 4;
            this.lblExitCode.Text = "Status: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 213);
            this.Controls.Add(this.lblExitCode);
            this.Controls.Add(this.lblProcessId);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Child Process";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Label lblProcessId;
        private System.Windows.Forms.Label lblExitCode;
    }
}