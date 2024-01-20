namespace TheNeighborhoodApp
{
    partial class UserControlNotificationControl
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
            this.txtDetails.Location = new System.Drawing.Point(73, 25);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(394, 38);
            this.txtDetails.TabIndex = 8;
            this.txtDetails.Text = "details";
            this.txtDetails.Click += new System.EventHandler(this.txtDetails_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(67, 3);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(89, 17);
            this.txtCategory.TabIndex = 7;
            this.txtCategory.Text = "New Concern";
            this.txtCategory.Click += new System.EventHandler(this.txtDetails_Click);
            // 
            // pic
            // 
            this.pic.Image = global::TheNeighborhoodApp.Properties.Resources._420090728_353519404162221_526689542767889419_n;
            this.pic.Location = new System.Drawing.Point(1, 1);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(63, 61);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.txtDetails_Click);
            // 
            // UserControlNotificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.pic);
            this.Name = "UserControlNotificationControl";
            this.Size = new System.Drawing.Size(483, 64);
            this.Click += new System.EventHandler(this.UserControlNotificationControl_Click);
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
