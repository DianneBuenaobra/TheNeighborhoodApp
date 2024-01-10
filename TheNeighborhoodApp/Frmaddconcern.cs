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
    public partial class Frmaddconcern : Form
    {
        public Frmaddconcern()
        {
            InitializeComponent();
            cnn = new SqlConnection(dbcon.MyConnection());
            cnn.Open();
        }
    }
}
