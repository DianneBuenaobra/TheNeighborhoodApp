using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeighborhoodApp
{
    public partial class FrmAdminResidentsList : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        public FrmAdminResidentsList()
        {
            InitializeComponent();
        }

        private void FrmAdminResidentsList_Load(object sender, EventArgs e)
        {

        }
        public void DisplayList()
        {
            string query = "Select * from UserInfo";
            sqlAdapter = new SqlDataAdapter(query, cnn);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);


        }

    }
}
