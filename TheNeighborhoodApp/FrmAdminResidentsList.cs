using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace TheNeighborhoodApp
{
    public partial class FrmAdminResidentsList : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;
        DBConnection db = new DBConnection();
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        public FrmAdminResidentsList()
        {
            InitializeComponent();
            cnn = new SqlConnection(db.MyConnection());cnn.Open();
        }

        private void FrmAdminResidentsList_Load(object sender, EventArgs e)
        {
            DisplayList("");
            eventclickSearch();


        }
        public void DisplayList(string txtSearch)
        {
            
            string query = "Select * from dbo.UserInfo WHERE CONCAT([First name],[Last Name],Age,Street,[Home number], gender, " +
                "Username, Password, UserType,[Date registered],[Phone Number], Verified)" +
                "LIKE '%"+ txtSearch + "%'";
            sqlAdapter = new SqlDataAdapter(query, cnn);
            dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            cnn.Close();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            btnX.Visible = true;
            DisplayList(tbSearch.Text.ToString());
            if (tbSearch.Text == "")
            {
                cnn.Open();
                sqlAdapter = new SqlDataAdapter("select * from dbo.UserInfo", cnn);
                dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                cnn.Close();
                btnX.Visible = false;
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            IconSearch.Visible = false;
            label1.Visible = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void FrmAdminResidentsList_Click(object sender, EventArgs e)
        {
            eventclickSearch();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventclickSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eventclickSearch();
            btnEdit.Visible = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        public void eventclickSearch()
        {
            IconSearch.Visible = true;tbSearch.Text = "";btnX.Visible = false; label1.Visible = true;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            eventclickSearch();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
