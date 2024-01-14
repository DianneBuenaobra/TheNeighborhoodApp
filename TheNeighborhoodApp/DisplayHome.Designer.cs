namespace TheNeighborhoodApp
{
    partial class DisplayHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homepnl = new System.Windows.Forms.Panel();
            this.concernMessage = new System.Windows.Forms.Label();
            this.concernBtn = new System.Windows.Forms.Button();
            this.announcementBtn = new System.Windows.Forms.Button();
            this.homepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepnl
            // 
            this.homepnl.Controls.Add(this.concernMessage);
            this.homepnl.Location = new System.Drawing.Point(4, 47);
            this.homepnl.Name = "homepnl";
            this.homepnl.Size = new System.Drawing.Size(499, 600);
            this.homepnl.TabIndex = 7;
            this.homepnl.Paint += new System.Windows.Forms.PaintEventHandler(this.homepnl_Paint);
            // 
            // concernMessage
            // 
            this.concernMessage.AutoSize = true;
            this.concernMessage.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concernMessage.Location = new System.Drawing.Point(60, 232);
            this.concernMessage.MaximumSize = new System.Drawing.Size(400, 300);
            this.concernMessage.Name = "concernMessage";
            this.concernMessage.Size = new System.Drawing.Size(378, 28);
            this.concernMessage.TabIndex = 0;
            this.concernMessage.Text = "This feature is only for verified resident. Please wait for the admin to confirm " +
    "your account. Thank you!";
            // 
            // concernBtn
            // 
            this.concernBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.concernBtn.ForeColor = System.Drawing.Color.White;
            this.concernBtn.Location = new System.Drawing.Point(262, 5);
            this.concernBtn.Name = "concernBtn";
            this.concernBtn.Size = new System.Drawing.Size(223, 36);
            this.concernBtn.TabIndex = 6;
            this.concernBtn.Text = "Concern";
            this.concernBtn.UseVisualStyleBackColor = false;
            this.concernBtn.Click += new System.EventHandler(this.concernBtn_Click);
            // 
            // announcementBtn
            // 
            this.announcementBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.announcementBtn.ForeColor = System.Drawing.Color.White;
            this.announcementBtn.Location = new System.Drawing.Point(22, 5);
            this.announcementBtn.Name = "announcementBtn";
            this.announcementBtn.Size = new System.Drawing.Size(215, 36);
            this.announcementBtn.TabIndex = 5;
            this.announcementBtn.Text = "Announcement";
            this.announcementBtn.UseVisualStyleBackColor = false;
            this.announcementBtn.Click += new System.EventHandler(this.announcementBtn_Click);
            // 
            // DisplayHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 652);
            this.ControlBox = false;
            this.Controls.Add(this.homepnl);
            this.Controls.Add(this.concernBtn);
            this.Controls.Add(this.announcementBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayHome";
            this.Load += new System.EventHandler(this.DisplayHome_Load);
            this.homepnl.ResumeLayout(false);
            this.homepnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homepnl;
        private System.Windows.Forms.Label concernMessage;
        private System.Windows.Forms.Button concernBtn;
        private System.Windows.Forms.Button announcementBtn;
    }
}