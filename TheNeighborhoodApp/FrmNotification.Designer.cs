namespace TheNeighborhoodApp
{
    partial class FrmNotification
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
            this.flowNotif = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowNotif
            // 
            this.flowNotif.AutoScroll = true;
            this.flowNotif.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowNotif.Location = new System.Drawing.Point(7, 32);
            this.flowNotif.Name = "flowNotif";
            this.flowNotif.Size = new System.Drawing.Size(492, 608);
            this.flowNotif.TabIndex = 3;
            this.flowNotif.Paint += new System.Windows.Forms.PaintEventHandler(this.flowAdminMessage_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TheNeighborhoodApp.Properties.Resources.reload__2_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 652);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowNotif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotification";
            this.Load += new System.EventHandler(this.FrmAdminMessages_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowNotif;
        private System.Windows.Forms.Button button1;
    }
}