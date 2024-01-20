namespace TheNeighborhoodApp
{
    partial class UserControlMessages
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.proflepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proflepic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(67, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(42, 17);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "name";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(73, 23);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(408, 38);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = "message";
            this.txtMessage.Click += new System.EventHandler(this.UserControlMessages_Click);
            // 
            // proflepic
            // 
            this.proflepic.Location = new System.Drawing.Point(1, 1);
            this.proflepic.Name = "proflepic";
            this.proflepic.Size = new System.Drawing.Size(63, 61);
            this.proflepic.TabIndex = 0;
            this.proflepic.TabStop = false;
            this.proflepic.Click += new System.EventHandler(this.UserControlMessages_Click);
            // 
            // UserControlMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.proflepic);
            this.Name = "UserControlMessages";
            this.Size = new System.Drawing.Size(483, 64);
            this.Load += new System.EventHandler(this.UserControlMessages_Load);
            this.Click += new System.EventHandler(this.UserControlMessages_Click);
            ((System.ComponentModel.ISupportInitialize)(this.proflepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox proflepic;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtMessage;
    }
}
