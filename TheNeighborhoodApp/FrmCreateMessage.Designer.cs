namespace TheNeighborhoodApp
{
    partial class FrmCreateMessage
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
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pMessage = new System.Windows.Forms.Panel();
            this.flowContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // tbContact
            // 
            this.tbContact.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContact.Location = new System.Drawing.Point(58, 42);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(379, 20);
            this.tbContact.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contacts";
            // 
            // pMessage
            // 
            this.pMessage.Location = new System.Drawing.Point(483, 103);
            this.pMessage.Name = "pMessage";
            this.pMessage.Size = new System.Drawing.Size(440, 521);
            this.pMessage.TabIndex = 3;
            this.pMessage.Visible = false;
            // 
            // flowContacts
            // 
            this.flowContacts.AutoScroll = true;
            this.flowContacts.BackColor = System.Drawing.Color.White;
            this.flowContacts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowContacts.Location = new System.Drawing.Point(21, 104);
            this.flowContacts.Name = "flowContacts";
            this.flowContacts.Size = new System.Drawing.Size(444, 459);
            this.flowContacts.TabIndex = 4;
            // 
            // FrmCreateMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 636);
            this.ControlBox = false;
            this.Controls.Add(this.flowContacts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateMessage";
            this.Load += new System.EventHandler(this.FrmCreateMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pMessage;
        private System.Windows.Forms.FlowLayoutPanel flowContacts;
    }
}