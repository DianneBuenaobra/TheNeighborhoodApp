namespace TheNeighborhoodApp
{
    partial class FrmHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.PictureBox();
            this.PnlmanageAcc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.slctMessage = new System.Windows.Forms.PictureBox();
            this.slctNotif = new System.Windows.Forms.PictureBox();
            this.slctHome = new System.Windows.Forms.PictureBox();
            this.btnNotif = new System.Windows.Forms.PictureBox();
            this.btnMessage = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lineNotif = new System.Windows.Forms.PictureBox();
            this.lineMessage = new System.Windows.Forms.PictureBox();
            this.lineHome = new System.Windows.Forms.PictureBox();
            this.btnProfile = new System.Windows.Forms.PictureBox();
            this.panelHomepage = new System.Windows.Forms.Panel();
            this.Pnllogout = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnManageAcc = new System.Windows.Forms.Button();
            this.slctCalendar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
            this.PnlmanageAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctNotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            this.Pnllogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slctCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.PnlmanageAcc);
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.slctMessage);
            this.panel1.Controls.Add(this.slctNotif);
            this.panel1.Controls.Add(this.slctHome);
            this.panel1.Controls.Add(this.btnNotif);
            this.panel1.Controls.Add(this.btnMessage);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lineNotif);
            this.panel1.Controls.Add(this.lineMessage);
            this.panel1.Controls.Add(this.lineHome);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.Location = new System.Drawing.Point(473, 7);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(23, 22);
            this.btnCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalendar.TabIndex = 17;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // PnlmanageAcc
            // 
            this.PnlmanageAcc.Controls.Add(this.label1);
            this.PnlmanageAcc.Controls.Add(this.pictureBox1);
            this.PnlmanageAcc.Location = new System.Drawing.Point(-1, 0);
            this.PnlmanageAcc.Name = "PnlmanageAcc";
            this.PnlmanageAcc.Size = new System.Drawing.Size(505, 67);
            this.PnlmanageAcc.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONAL DATA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheNeighborhoodApp.Properties.Resources.previous;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.SteelBlue;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(41, 9);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(41, 15);
            this.usernamelbl.TabIndex = 14;
            this.usernamelbl.Text = "label1";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // slctMessage
            // 
            this.slctMessage.Image = ((System.Drawing.Image)(resources.GetObject("slctMessage.Image")));
            this.slctMessage.Location = new System.Drawing.Point(240, 27);
            this.slctMessage.Name = "slctMessage";
            this.slctMessage.Size = new System.Drawing.Size(28, 28);
            this.slctMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctMessage.TabIndex = 13;
            this.slctMessage.TabStop = false;
            this.slctMessage.Visible = false;
            this.slctMessage.Click += new System.EventHandler(this.slctMessage_Click);
            // 
            // slctNotif
            // 
            this.slctNotif.Image = ((System.Drawing.Image)(resources.GetObject("slctNotif.Image")));
            this.slctNotif.Location = new System.Drawing.Point(413, 27);
            this.slctNotif.Name = "slctNotif";
            this.slctNotif.Size = new System.Drawing.Size(28, 28);
            this.slctNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctNotif.TabIndex = 12;
            this.slctNotif.TabStop = false;
            this.slctNotif.Visible = false;
            this.slctNotif.Click += new System.EventHandler(this.slctNotif_Click);
            // 
            // slctHome
            // 
            this.slctHome.Image = ((System.Drawing.Image)(resources.GetObject("slctHome.Image")));
            this.slctHome.Location = new System.Drawing.Point(72, 27);
            this.slctHome.Name = "slctHome";
            this.slctHome.Size = new System.Drawing.Size(28, 28);
            this.slctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctHome.TabIndex = 10;
            this.slctHome.TabStop = false;
            this.slctHome.Click += new System.EventHandler(this.slctHome_Click);
            // 
            // btnNotif
            // 
            this.btnNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotif.Image = ((System.Drawing.Image)(resources.GetObject("btnNotif.Image")));
            this.btnNotif.Location = new System.Drawing.Point(413, 27);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(28, 28);
            this.btnNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNotif.TabIndex = 4;
            this.btnNotif.TabStop = false;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnMessage.Image")));
            this.btnMessage.Location = new System.Drawing.Point(240, 27);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(28, 28);
            this.btnMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMessage.TabIndex = 3;
            this.btnMessage.TabStop = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(72, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(28, 28);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lineNotif
            // 
            this.lineNotif.Image = ((System.Drawing.Image)(resources.GetObject("lineNotif.Image")));
            this.lineNotif.Location = new System.Drawing.Point(334, 49);
            this.lineNotif.Name = "lineNotif";
            this.lineNotif.Size = new System.Drawing.Size(171, 28);
            this.lineNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineNotif.TabIndex = 8;
            this.lineNotif.TabStop = false;
            this.lineNotif.Visible = false;
            this.lineNotif.Click += new System.EventHandler(this.lineNotif_Click);
            // 
            // lineMessage
            // 
            this.lineMessage.Image = ((System.Drawing.Image)(resources.GetObject("lineMessage.Image")));
            this.lineMessage.Location = new System.Drawing.Point(167, 49);
            this.lineMessage.Name = "lineMessage";
            this.lineMessage.Size = new System.Drawing.Size(171, 28);
            this.lineMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineMessage.TabIndex = 9;
            this.lineMessage.TabStop = false;
            this.lineMessage.Visible = false;
            this.lineMessage.Click += new System.EventHandler(this.lineMessage_Click);
            // 
            // lineHome
            // 
            this.lineHome.Image = ((System.Drawing.Image)(resources.GetObject("lineHome.Image")));
            this.lineHome.Location = new System.Drawing.Point(1, 49);
            this.lineHome.Name = "lineHome";
            this.lineHome.Size = new System.Drawing.Size(171, 28);
            this.lineHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineHome.TabIndex = 7;
            this.lineHome.TabStop = false;
            this.lineHome.Click += new System.EventHandler(this.lineHome_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(5, 5);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(30, 30);
            this.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProfile.TabIndex = 1;
            this.btnProfile.TabStop = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelHomepage
            // 
            this.panelHomepage.BackColor = System.Drawing.Color.White;
            this.panelHomepage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHomepage.Location = new System.Drawing.Point(0, 70);
            this.panelHomepage.Name = "panelHomepage";
            this.panelHomepage.Size = new System.Drawing.Size(505, 655);
            this.panelHomepage.TabIndex = 1;
            this.panelHomepage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHomepage_Paint);
            this.panelHomepage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHomepage_MouseClick);
            // 
            // Pnllogout
            // 
            this.Pnllogout.BackColor = System.Drawing.Color.Transparent;
            this.Pnllogout.BackgroundImage = global::TheNeighborhoodApp.Properties.Resources.hvhv;
            this.Pnllogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnllogout.Controls.Add(this.BtnLogout);
            this.Pnllogout.Controls.Add(this.BtnManageAcc);
            this.Pnllogout.Location = new System.Drawing.Point(25, 26);
            this.Pnllogout.Name = "Pnllogout";
            this.Pnllogout.Size = new System.Drawing.Size(165, 80);
            this.Pnllogout.TabIndex = 15;
            this.Pnllogout.MouseEnter += new System.EventHandler(this.Pnllogout_MouseEnter);
            this.Pnllogout.MouseLeave += new System.EventHandler(this.Pnllogout_MouseLeave);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(11, 46);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(144, 23);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnManageAcc
            // 
            this.BtnManageAcc.Location = new System.Drawing.Point(11, 15);
            this.BtnManageAcc.Name = "BtnManageAcc";
            this.BtnManageAcc.Size = new System.Drawing.Size(144, 23);
            this.BtnManageAcc.TabIndex = 0;
            this.BtnManageAcc.Text = "Manage Account";
            this.BtnManageAcc.UseVisualStyleBackColor = true;
            this.BtnManageAcc.Click += new System.EventHandler(this.BtnManageAcc_Click);
            // 
            // FrmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 725);
            this.Controls.Add(this.Pnllogout);
            this.Controls.Add(this.panelHomepage);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHomepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
            this.PnlmanageAcc.ResumeLayout(false);
            this.PnlmanageAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctNotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            this.Pnllogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMessage;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnProfile;
        private System.Windows.Forms.PictureBox slctHome;
        private System.Windows.Forms.PictureBox lineNotif;
        private System.Windows.Forms.PictureBox lineMessage;
        private System.Windows.Forms.PictureBox lineHome;
        private System.Windows.Forms.PictureBox slctMessage;
        private System.Windows.Forms.PictureBox slctNotif;
        private System.Windows.Forms.PictureBox btnNotif;
        private System.Windows.Forms.Panel panelHomepage;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnManageAcc;
        private System.Windows.Forms.Panel PnlmanageAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel Pnllogout;
        private System.Windows.Forms.PictureBox btnCalendar;
    }
}