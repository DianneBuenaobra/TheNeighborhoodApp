namespace TheNeighborhoodApp
{
    partial class AdminNotificationConcernInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminNotificationConcernInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblconcerninfo = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblconcern = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concern:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Concern Information";
            // 
            // lblconcerninfo
            // 
            this.lblconcerninfo.AutoSize = true;
            this.lblconcerninfo.Location = new System.Drawing.Point(27, 93);
            this.lblconcerninfo.MaximumSize = new System.Drawing.Size(340, 90);
            this.lblconcerninfo.Name = "lblconcerninfo";
            this.lblconcerninfo.Size = new System.Drawing.Size(340, 90);
            this.lblconcerninfo.TabIndex = 3;
            this.lblconcerninfo.Text = resources.GetString("lblconcerninfo.Text");
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(59, 15);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 15);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name:";
            // 
            // lblconcern
            // 
            this.lblconcern.AutoSize = true;
            this.lblconcern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconcern.Location = new System.Drawing.Point(71, 40);
            this.lblconcern.Name = "lblconcern";
            this.lblconcern.Size = new System.Drawing.Size(44, 15);
            this.lblconcern.TabIndex = 5;
            this.lblconcern.Text = "Name:";
            // 
            // AdminNotificationConcernInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(401, 196);
            this.Controls.Add(this.lblconcern);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblconcerninfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminNotificationConcernInfo";
            this.Text = "Concern Information";
            this.Load += new System.EventHandler(this.AdminNotificationConcernInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblconcerninfo;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblconcern;
    }
}