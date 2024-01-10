using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace TheNeighborhoodApp
{
    public partial class FrmConcernResident : Form
    {
        public FrmConcernResident()
        {
            InitializeComponent();
        }

        private List<Concern> concern = new List<Concern>();
        private void AddMovieToUI(Concern concern)
        {
            //Create panel
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("PnlMovie{0}", concern.concernId);
            panel.BackColor = Color.White;
            panel.Size = new Size(125, 205);
            panel.Margin = new Padding(10);
            panel.Tag = concern.concernId;

            //Create picture box
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("PbMovieImage{0}", concern.concernId);
            picBox.Size = new Size(100, 148);
            picBox.Location = new Point(12, 10);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
           
            if (File.Exists(concern.Imagepath))
                picBox.Image = Image.FromFile(concern.Imagepath);

            picBox.Tag = concern.concernId;

            //Create title label
            Label labelTitle;
            labelTitle = new Label();
            labelTitle.Name = String.Format("LblMovieTitle{0}", concern.concernId);
            labelTitle.Text = concern.concern;
            labelTitle.Location = new Point(12, 165);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            labelTitle.AutoSize = true;
            labelTitle.Tag = concern.concernId;

            //Create year label
            Label labelYear;
            labelYear = new Label();
            labelYear.Name = String.Format("LblMovieYear{0}", concern.concernId);
            labelYear.Text = concern.date.ToString();
            labelYear.Location = new Point(12, 185);
            labelYear.ForeColor = Color.Gray;
            labelYear.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            labelYear.Tag = concern.concernId;

            //Set Context Menu
            panel.ContextMenuStrip = contextMenuStrip1;

            //Add controls to panel 
            panel.Controls.Add(picBox);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labelYear);

            //Add Event Handlers 
            panel.DoubleClick += new EventHandler(Edit_DoubleClick);

            foreach (Control c in panel.Controls)
            {
                c.DoubleClick += new EventHandler(Edit_DoubleClick);
            }

            //Add panel to flowlayoutpanel
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void Edit_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
