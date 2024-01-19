namespace TheNeighborhoodApp
{
    partial class FrmAdminMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMessages));
            this.flowAdminMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowAdminMessage
            // 
            this.flowAdminMessage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowAdminMessage.Location = new System.Drawing.Point(0, -1);
            this.flowAdminMessage.Name = "flowAdminMessage";
            this.flowAdminMessage.Size = new System.Drawing.Size(489, 637);
            this.flowAdminMessage.TabIndex = 3;
            this.flowAdminMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.flowAdminMessage_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No Messages";
            this.label1.Visible = false;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMessage.Image")));
            this.btnAddMessage.Location = new System.Drawing.Point(431, 578);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(46, 46);
            this.btnAddMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddMessage.TabIndex = 3;
            this.btnAddMessage.TabStop = false;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // FrmAdminMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 636);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowAdminMessage);
            this.Controls.Add(this.btnAddMessage);
            this.Name = "FrmAdminMessages";
            this.Load += new System.EventHandler(this.FrmAdminMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowAdminMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnAddMessage;
    }
}