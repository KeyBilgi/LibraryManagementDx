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
using LibraryManagement_Beta.Base;

namespace LibraryManagement_Beta
{
    public partial class frmIssueBook : Form
    {
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        public frmIssueBook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// hartip 1 çıkış
        /// hartip 2 giriş
        /// </summary>
        private void ConfigureCombos()
        {
            lookUpEdit1.SelectedText = "";
           
            
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
            cSqlCommand cmm = new cSqlCommand();
            cmm.CommandText = "SELECT a.id, a.customerid, a.kitapid, a.hartip, a.tarih, ogrenciad = b.ad, kitapad = c.ad  " +
                "FROM tbl_hareket a " +
                "INNER JOIN tbl_customer b on b.id = a.customerid " +
                "INNER JOIN tbl_kitap c on c.id = a.kitapid " +
                "WHERE a.hartip = 1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmm.CommandObject);
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void AddHarCikis()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "INSERT INTO tbl_hareket (customerid, kitapid, hartip, tarih) VALUES(@customerid, @kitapid, @hartip, @tarih)";
            cmm.Parameters.AddWithValue("@customerid", Convert.ToInt32(lookUpEdit2.EditValue));
            cmm.Parameters.AddWithValue("@kitapid", Convert.ToInt32(lookUpEdit1.EditValue));
            cmm.Parameters.AddWithValue("@hartip", 1);
            cmm.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmm.Connection.Open();
            cmm.ExecuteNonQuery();
            cmm.Connection.Close();
        }
        private bool FormValidate()
        {
            if (Convert.ToInt32(lookUpEdit1.EditValue) < 1)
            {
                MessageBox.Show("Kitap Seçilmemiş");
                return false;
            }
            if (Convert.ToInt32(lookUpEdit2.EditValue) < 1)
            {
                MessageBox.Show("Öğrenci Seçilmemiş");
                return false;
            }
            return true;
        }
        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            ConfigureCombos();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                AddHarCikis();
                LoadData();

                lookUpEdit1.EditValue = -1;
                lookUpEdit2.EditValue = -1;
            }
        }
    }
}
