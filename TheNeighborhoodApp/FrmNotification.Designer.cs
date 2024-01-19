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
            this.SuspendLayout();
            // 
            // flowNotif
            // 
            this.flowNotif.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowNotif.Location = new System.Drawing.Point(0, -1);
            this.flowNotif.Name = "flowNotif";
            this.flowNotif.Size = new System.Drawing.Size(489, 638);
            this.flowNotif.TabIndex = 3;
            this.flowNotif.Paint += new System.Windows.Forms.PaintEventHandler(this.flowAdminMessage_Paint);
            // 
            // FrmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 636);
            this.ControlBox = false;
            this.Controls.Add(this.flowNotif);
            this.Name = "FrmNotification";
            this.Load += new System.EventHandler(this.FrmAdminMessages_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowNotif;
    }
}