﻿namespace TheNeighborhoodApp
{
    partial class AdminAddAnnouncement
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
            this.concerninfotxtbx = new System.Windows.Forms.TextBox();
            this.concerntxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.picboxConcern = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picboxConcern)).BeginInit();
            this.SuspendLayout();
            // 
            // concerninfotxtbx
            // 
            this.concerninfotxtbx.Location = new System.Drawing.Point(63, 155);
            this.concerninfotxtbx.Multiline = true;
            this.concerninfotxtbx.Name = "concerninfotxtbx";
            this.concerninfotxtbx.Size = new System.Drawing.Size(293, 181);
            this.concerninfotxtbx.TabIndex = 25;
            // 
            // concerntxtbx
            // 
            this.concerntxtbx.Location = new System.Drawing.Point(63, 105);
            this.concerntxtbx.Name = "concerntxtbx";
            this.concerntxtbx.Size = new System.Drawing.Size(293, 20);
            this.concerntxtbx.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Choose date to post:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Photo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Announcement Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Announcement Title:";
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(156, 487);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(98, 24);
            this.submitbtn.TabIndex = 16;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(263, 372);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(63, 24);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            // 
            // picboxConcern
            // 
            this.picboxConcern.BackColor = System.Drawing.Color.White;
            this.picboxConcern.Image = global::TheNeighborhoodApp.Properties.Resources.background;
            this.picboxConcern.Location = new System.Drawing.Point(65, 372);
            this.picboxConcern.Name = "picboxConcern";
            this.picboxConcern.Size = new System.Drawing.Size(189, 85);
            this.picboxConcern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxConcern.TabIndex = 14;
            this.picboxConcern.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // AdminAddAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 535);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.concerninfotxtbx);
            this.Controls.Add(this.concerntxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.picboxConcern);
            this.Name = "AdminAddAnnouncement";
            this.Text = "AdminAddAnnouncement";
            ((System.ComponentModel.ISupportInitialize)(this.picboxConcern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox concerninfotxtbx;
        private System.Windows.Forms.TextBox concerntxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox picboxConcern;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}