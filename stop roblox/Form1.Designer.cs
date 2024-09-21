namespace stop_roblox
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
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label(); // Add status label here
            this.SuspendLayout();

            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.DarkRed;
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(100, 250);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(150, 50);
            this.buttonStop.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);

            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonResume.ForeColor = System.Drawing.Color.White;
            this.buttonResume.Location = new System.Drawing.Point(350, 250);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(150, 50);
            this.buttonResume.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.ButtonResume_Click);

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(125, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 29);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Text = "Control the RobloxPlayerBeta Process";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(200, 150);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(200, 29);
            this.labelStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelStatus.Text = "Status: Unknown";

            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelStatus); // Add status label to the form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Roblox Controller";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus; // Define the status label here
    }
}
