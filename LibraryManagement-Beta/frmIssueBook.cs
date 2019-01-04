using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace LibraryManagement_Beta
{
    public partial class frmIssueBook : Form
    {
        public frmIssueBook()
        {
            InitializeComponent();
        }

        private void ConfigureCombos()
        {
            lookUpEdit1.SelectedText = "";
            SqlConnection con = new SqlConnection(cons.getConnectionString());
            
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "SELECT a.id, a.ad, a.yazari, a.yayinevi, a.barkodno FROM tbl_kitap a";
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dtkitap = new DataTable();
            da.Fill(dtkitap);
            lookUpEdit1.Properties.DataSource = dtkitap;
            lookUpEdit1.Properties.DisplayMember = "ad";
            lookUpEdit1.Properties.ValueMember = "id";

            cmm.Parameters.Clear();
            cmm.CommandText = "SELECT a.id, a.ad, a.soyad, a.tc FROM tbl_customer a";
            DataTable dtstudent = new DataTable();
            da.Fill(dtstudent);
            lookUpEdit2.Properties.DataSource = dtstudent;
            lookUpEdit2.Properties.DisplayMember = "ad";
            lookUpEdit2.Properties.ValueMember = "id";


        }
        private void LoadData()
        {

        }
        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            ConfigureCombos();
            LoadData();
        }
    }
}
