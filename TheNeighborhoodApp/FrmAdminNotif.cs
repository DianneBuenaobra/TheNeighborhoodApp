using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class FrmAdminNotif : Form
    {
        public FrmAdminNotif()
        {
            InitializeComponent();
        }
        public int concernid { get; set; }
        public string concernname { get; set; }
        public string concerndescription { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string concernstatus { get; set; }
        public void concernpanels()
        {

            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlConcern{0}", concernid);
            panel.BackColor = Color.SteelBlue;
            panel.Size = new Size(484, 65); //125, 205
            panel.Margin = new Padding(15);
            panel.Location = new Point(15, 50);
            panel.Tag = concernid;


            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblConcernTitle{0}", concernid);
            labelTitle.Text = concernname;
            labelTitle.Location = new Point(11, 40);
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Tag = concernid;
            labelTitle.MaximumSize = new Size(240, 40);
            labelTitle.MinimumSize = new Size(230, 30);


            Label labeldescription;
            labeldescription = new Label();
            labeldescription.Name = String.Format("LblConcernTitle{0}", concernid);
            labeldescription.Text = concerndescription;
            labeldescription.Location = new Point(10, 75);
            labeldescription.ForeColor = Color.Black;
            labeldescription.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldescription.AutoSize = true;
            labeldescription.Tag = concernid;
            labeldescription.MaximumSize = new Size(230, 75);
            labeldescription.MinimumSize = new Size(230, 75);
            labeldescription.BackColor = Color.White;

            Label labeldate;
            labeldate = new Label();
            labeldate.Name = String.Format("LblConcernYear{0}", concernid);
            labeldate.Text = date.ToString();
            labeldate.Location = new Point(10, 11);
            labeldate.ForeColor = Color.WhiteSmoke;
            labeldate.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labeldate.Tag = concernid;

            Label labelstatus;
            labelstatus = new Label();
            labelstatus.Name = String.Format("LblConcernStatus{0}", concernid);
            labelstatus.Text = concernstatus;
            labelstatus.Location = new Point(187, 10);
            labelstatus.ForeColor = Color.WhiteSmoke;
            labelstatus.Font = new Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular);
            labelstatus.Tag = concernid;

            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbconcernImage{0}", concernid);
            picBox.Size = new Size(63, 59);
            picBox.Location = new Point(3, 3);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BackColor = Color.White;

            Button button;
            button = new Button();
            button.Name = String.Format("PbconcernButton{0}", concernid);
            button.Size = new Size(145, 26);
            button.Text = "Contact Admin";
            button.Location = new Point(255, 136);
            button.ForeColor = Color.White;
            button.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular);
            button.Tag = concernid;
            //button.Click += new EventHandler(this.button_click);
            /*
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            picBox.Tag = movie.Id;
            */

            panel.Controls.Add(button);
            panel.Controls.Add(picBox);
            panel.Controls.Add(labelstatus);
            panel.Controls.Add(labeldate);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labeldescription);
            flowLayoutPanel1.Controls.Add(panel);

        }
    }
}