namespace TheNeighborhoodApp
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
            this.slctMessage = new System.Windows.Forms.PictureBox();
            this.slctNotif = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slctMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctNotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.slctMessage);
            this.panel1.Controls.Add(this.slctNotif);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 43);
            this.panel1.TabIndex = 1;
            // 
            // slctMessage
            // 
            this.slctMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctMessage.Image = ((System.Drawing.Image)(resources.GetObject("slctMessage.Image")));
            this.slctMessage.Location = new System.Drawing.Point(424, 6);
            this.slctMessage.Name = "slctMessage";
            this.slctMessage.Size = new System.Drawing.Size(30, 30);
            this.slctMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctMessage.TabIndex = 13;
            this.slctMessage.TabStop = false;
            // 
            // slctNotif
            // 
            this.slctNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctNotif.Image = ((System.Drawing.Image)(resources.GetObject("slctNotif.Image")));
            this.slctNotif.Location = new System.Drawing.Point(462, 6);
            this.slctNotif.Name = "slctNotif";
            this.slctNotif.Size = new System.Drawing.Size(30, 30);
            this.slctNotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slctNotif.TabIndex = 12;
            this.slctNotif.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(7, 7);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 29);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 724);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(153, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 22);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 5;
            this.btnBack.TabStop = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAdminHomepage";
            this.Load += new System.EventHandler(this.FrmAdminHomepage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slctMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slctNotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox slctMessage;
        private System.Windows.Forms.PictureBox slctNotif;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnBack;
    }
}