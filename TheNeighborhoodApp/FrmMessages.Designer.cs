﻿namespace TheNeighborhoodApp
{
    partial class FrmMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessages));
            this.label1 = new System.Windows.Forms.Label();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMessage = new System.Windows.Forms.PictureBox();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Messages";
            this.label1.Visible = false;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.White;
            this.panelMessage.Controls.Add(this.label1);
            this.panelMessage.Controls.Add(this.flowLayoutPanel1);
            this.panelMessage.Controls.Add(this.btnAddMessage);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(489, 636);
            this.panelMessage.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 636);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMessage.Image")));
            this.btnAddMessage.Location = new System.Drawing.Point(431, 578);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(46, 46);
            this.btnAddMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddMessage.TabIndex = 1;
            this.btnAddMessage.TabStop = false;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // FrmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 636);
            this.ControlBox = false;
            this.Controls.Add(this.panelMessage);
            this.Name = "FrmMessages";
            this.Load += new System.EventHandler(this.FrmMessages_Load);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.PictureBox btnAddMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}