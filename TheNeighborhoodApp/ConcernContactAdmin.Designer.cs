namespace TheNeighborhoodApp
{
    partial class ConcernContactAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblconcern = new System.Windows.Forms.Label();
            this.lblConcernStatus = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concern: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concern Status: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message:";
            // 
            // lblconcern
            // 
            this.lblconcern.AutoSize = true;
            this.lblconcern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconcern.ForeColor = System.Drawing.Color.White;
            this.lblconcern.Location = new System.Drawing.Point(98, 19);
            this.lblconcern.Name = "lblconcern";
            this.lblconcern.Size = new System.Drawing.Size(59, 15);
            this.lblconcern.TabIndex = 3;
            this.lblconcern.Text = "Concern: ";
            // 
            // lblConcernStatus
            // 
            this.lblConcernStatus.AutoSize = true;
            this.lblConcernStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcernStatus.ForeColor = System.Drawing.Color.White;
            this.lblConcernStatus.Location = new System.Drawing.Point(135, 47);
            this.lblConcernStatus.Name = "lblConcernStatus";
            this.lblConcernStatus.Size = new System.Drawing.Size(59, 15);
            this.lblConcernStatus.TabIndex = 4;
            this.lblConcernStatus.Text = "Concern: ";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(36, 102);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(419, 105);
            this.txtmessage.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConcernContactAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(495, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.lblConcernStatus);
            this.Controls.Add(this.lblconcern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConcernContactAdmin";
            this.Text = "kkn43";
            this.Load += new System.EventHandler(this.ConcernContactAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblconcern;
        private System.Windows.Forms.Label lblConcernStatus;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button button1;
    }
}