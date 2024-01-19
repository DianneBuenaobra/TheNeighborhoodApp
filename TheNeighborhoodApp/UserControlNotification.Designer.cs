namespace TheNeighborhoodApp
{
    partial class UserControlNotification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDetails = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(73, 26);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(408, 38);
            this.txtDetails.TabIndex = 5;
            this.txtDetails.Text = "details";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(67, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(62, 17);
            this.txtCategory.TabIndex = 4;
            this.txtCategory.Text = "category";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(1, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(63, 61);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // UserControlNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.pic);
            this.Name = "UserControlNotification";
            this.Size = new System.Drawing.Size(483, 64);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDetails;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.PictureBox pic;
    }
}
