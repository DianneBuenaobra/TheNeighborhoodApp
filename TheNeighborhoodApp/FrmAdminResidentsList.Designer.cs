﻿namespace TheNeighborhoodApp
{
    partial class FrmAdminResidentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminResidentsList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.IconSearch = new System.Windows.Forms.PictureBox();
            this.btnX = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(479, 528);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(12, 42);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(237, 22);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // IconSearch
            // 
            this.IconSearch.BackColor = System.Drawing.SystemColors.Window;
            this.IconSearch.Image = ((System.Drawing.Image)(resources.GetObject("IconSearch.Image")));
            this.IconSearch.Location = new System.Drawing.Point(13, 43);
            this.IconSearch.Name = "IconSearch";
            this.IconSearch.Size = new System.Drawing.Size(23, 19);
            this.IconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconSearch.TabIndex = 3;
            this.IconSearch.TabStop = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.Window;
            this.btnX.Image = ((System.Drawing.Image)(resources.GetObject("btnX.Image")));
            this.btnX.Location = new System.Drawing.Point(225, 45);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(20, 16);
            this.btnX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnX.TabIndex = 4;
            this.btnX.TabStop = false;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // FrmAdminResidentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 681);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.IconSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminResidentsList";
            this.Load += new System.EventHandler(this.FrmAdminResidentsList_Load);
            this.Click += new System.EventHandler(this.FrmAdminResidentsList_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox IconSearch;
        private System.Windows.Forms.PictureBox btnX;
        private System.Windows.Forms.Label label1;
    }
}