﻿namespace TheNeighborhoodApp
{
    partial class FrmAdminHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminHomepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.slctedMessage = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.slctMessage = new System.Windows.Forms.PictureBox();
            this.slctNotif = new System.Windows.Forms.PictureBox();
            this.menuList = new System.Windows.Forms.Panel();
            this.btnRList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnConcerns = new System.Windows.Forms.Button();
            this.AdminNF = new System.Windows.Forms.Panel();
            this.slctedNotif = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slctedMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctNotif)).BeginInit();
            this.menuList.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctedNotif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.slctedNotif);
            this.panel1.Controls.Add(this.slctedMessage);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.slctMessage);
            this.panel1.Controls.Add(this.slctNotif);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 43);
            this.panel1.TabIndex = 1;
            // 
            // slctedMessage
            // 
            this.slctedMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctedMessage.Image = ((System.Drawing.Image)(resources.GetObject("slctedMessage.Image")));
            this.slctedMessage.Location = new System.Drawing.Point(425, 6);
            this.slctedMessage.Name = "slctedMessage";
            this.slctedMessage.Size = new System.Drawing.Size(30, 30);
            this.slctedMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctedMessage.TabIndex = 18;
            this.slctedMessage.TabStop = false;
            this.slctedMessage.Visible = false;
            this.slctedMessage.Click += new System.EventHandler(this.slctedMessage_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(6, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 29);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // slctMessage
            // 
            this.slctMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctMessage.Image = ((System.Drawing.Image)(resources.GetObject("slctMessage.Image")));
            this.slctMessage.Location = new System.Drawing.Point(425, 5);
            this.slctMessage.Name = "slctMessage";
            this.slctMessage.Size = new System.Drawing.Size(30, 30);
            this.slctMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctMessage.TabIndex = 15;
            this.slctMessage.TabStop = false;
            this.slctMessage.Click += new System.EventHandler(this.slctMessage_Click);
            // 
            // slctNotif
            // 
            this.slctNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctNotif.Image = ((System.Drawing.Image)(resources.GetObject("slctNotif.Image")));
            this.slctNotif.Location = new System.Drawing.Point(463, 5);
            this.slctNotif.Name = "slctNotif";
            this.slctNotif.Size = new System.Drawing.Size(30, 30);
            this.slctNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctNotif.TabIndex = 14;
            this.slctNotif.TabStop = false;
            this.slctNotif.Click += new System.EventHandler(this.slctNotif_Click);
            // 
            // menuList
            // 
            this.menuList.BackColor = System.Drawing.Color.SteelBlue;
            this.menuList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuList.Controls.Add(this.btnRList);
            this.menuList.Controls.Add(this.panel2);
            this.menuList.Controls.Add(this.button5);
            this.menuList.Controls.Add(this.btnAnnouncements);
            this.menuList.Controls.Add(this.btnCalendar);
            this.menuList.Controls.Add(this.btnConcerns);
            this.menuList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.menuList.Location = new System.Drawing.Point(0, 0);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(184, 725);
            this.menuList.TabIndex = 3;
            this.menuList.Visible = false;
            // 
            // btnRList
            // 
            this.btnRList.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRList.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnRList.FlatAppearance.BorderSize = 0;
            this.btnRList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRList.Image = ((System.Drawing.Image)(resources.GetObject("btnRList.Image")));
            this.btnRList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRList.Location = new System.Drawing.Point(0, 399);
            this.btnRList.Name = "btnRList";
            this.btnRList.Size = new System.Drawing.Size(184, 52);
            this.btnRList.TabIndex = 7;
            this.btnRList.Text = " Residents List";
            this.btnRList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRList.UseVisualStyleBackColor = false;
            this.btnRList.Click += new System.EventHandler(this.btnRList_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 220);
            this.panel2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(151, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 16;
            this.btnBack.TabStop = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 673);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 52);
            this.button5.TabIndex = 10;
            this.button5.Text = "  Log out";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnouncements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnouncements.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAnnouncements.FlatAppearance.BorderSize = 0;
            this.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncements.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnouncements.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnouncements.Image")));
            this.btnAnnouncements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnouncements.Location = new System.Drawing.Point(-1, 254);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(184, 52);
            this.btnAnnouncements.TabIndex = 9;
            this.btnAnnouncements.Text = "  Announcements";
            this.btnAnnouncements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnouncements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 350);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(184, 52);
            this.btnCalendar.TabIndex = 8;
            this.btnCalendar.Text = "  Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnConcerns
            // 
            this.btnConcerns.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConcerns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConcerns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcerns.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnConcerns.FlatAppearance.BorderSize = 0;
            this.btnConcerns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcerns.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcerns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConcerns.Image = ((System.Drawing.Image)(resources.GetObject("btnConcerns.Image")));
            this.btnConcerns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcerns.Location = new System.Drawing.Point(-1, 302);
            this.btnConcerns.Name = "btnConcerns";
            this.btnConcerns.Size = new System.Drawing.Size(184, 52);
            this.btnConcerns.TabIndex = 6;
            this.btnConcerns.Text = "         Concerns";
            this.btnConcerns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcerns.UseVisualStyleBackColor = false;
            this.btnConcerns.Click += new System.EventHandler(this.btnConcerns_Click);
            // 
            // AdminNF
            // 
            this.AdminNF.Location = new System.Drawing.Point(0, 41);
            this.AdminNF.Name = "AdminNF";
            this.AdminNF.Size = new System.Drawing.Size(505, 684);
            this.AdminNF.TabIndex = 4;
            // 
            // slctedNotif
            // 
            this.slctedNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctedNotif.Image = ((System.Drawing.Image)(resources.GetObject("slctedNotif.Image")));
            this.slctedNotif.Location = new System.Drawing.Point(463, 5);
            this.slctedNotif.Name = "slctedNotif";
            this.slctedNotif.Size = new System.Drawing.Size(30, 30);
            this.slctedNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctedNotif.TabIndex = 19;
            this.slctedNotif.TabStop = false;
            this.slctedNotif.Visible = false;
            this.slctedNotif.Click += new System.EventHandler(this.slctedNotif_Click);
            // 
            // FrmAdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 725);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminNF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAdminHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdminHomepage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slctedMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctNotif)).EndInit();
            this.menuList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctedNotif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox slctMessage;
        private System.Windows.Forms.PictureBox slctNotif;
        public System.Windows.Forms.Panel menuList;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnRList;
        private System.Windows.Forms.Button btnConcerns;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox slctedMessage;
        private System.Windows.Forms.Panel AdminNF;
        private System.Windows.Forms.PictureBox slctedNotif;
    }
}