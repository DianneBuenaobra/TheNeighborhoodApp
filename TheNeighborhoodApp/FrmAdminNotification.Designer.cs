namespace TheNeighborhoodApp
{
    partial class FrmAdminNotification
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
            this.flowLayoutNotif = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNotifDesc = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Notifpic = new System.Windows.Forms.PictureBox();
            this.lblNotifTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Notifpic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutNotif
            // 
            this.flowLayoutNotif.Location = new System.Drawing.Point(8, 9);
            this.flowLayoutNotif.Name = "flowLayoutNotif";
            this.flowLayoutNotif.Size = new System.Drawing.Size(486, 664);
            this.flowLayoutNotif.TabIndex = 1;
            // 
            // lblNotifDesc
            // 
            this.lblNotifDesc.Location = new System.Drawing.Point(78, 24);
            this.lblNotifDesc.Name = "lblNotifDesc";
            this.lblNotifDesc.Size = new System.Drawing.Size(396, 33);
            this.lblNotifDesc.TabIndex = 3;
            this.lblNotifDesc.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(411, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            // 
            // Notifpic
            // 
            this.Notifpic.Location = new System.Drawing.Point(3, 3);
            this.Notifpic.Name = "Notifpic";
            this.Notifpic.Size = new System.Drawing.Size(63, 59);
            this.Notifpic.TabIndex = 1;
            this.Notifpic.TabStop = false;
            // 
            // lblNotifTitle
            // 
            this.lblNotifTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifTitle.Location = new System.Drawing.Point(72, 5);
            this.lblNotifTitle.Name = "lblNotifTitle";
            this.lblNotifTitle.Size = new System.Drawing.Size(321, 17);
            this.lblNotifTitle.TabIndex = 0;
            this.lblNotifTitle.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNotifDesc);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.Notifpic);
            this.panel1.Controls.Add(this.lblNotifTitle);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 68);
            this.panel1.TabIndex = 1;
            // 
            // FrmAdminNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 682);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutNotif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminNotification";
            ((System.ComponentModel.ISupportInitialize)(this.Notifpic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutNotif;
        private System.Windows.Forms.Label lblNotifDesc;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox Notifpic;
        private System.Windows.Forms.Label lblNotifTitle;
        private System.Windows.Forms.Panel panel1;
    }
}