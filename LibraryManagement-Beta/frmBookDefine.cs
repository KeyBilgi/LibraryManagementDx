using LibraryManagement;
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

namespace LibraryManagement_Beta
{
    public partial class frmBookDefine : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmBookDefine()
        {
            InitializeComponent();
        }
        DataTable dtMain = null;
        SqlDataAdapter daMain = null;

        private void LoadData()
        {
            dtMain = new DataTable();
            SqlConnection con = new SqlConnection(cons.getConnectionString());
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "SELECT a.id, a.ad, a.sayfasayisi, a.yayinevi, a.barkodno, a.yazari, a.location, a.kategori, a.aciklama " +
                "FROM tbl_kitap a";
            daMain = new SqlDataAdapter(cmm);
            cCommandBuilder cb = new cCommandBuilder();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("aciklama", SqlDbType.VarChar, 100);
            cb.AddField("ad", SqlDbType.VarChar, 30);
            cb.AddField("sayfasayisi", SqlDbType.VarChar, 30);
            cb.AddField("yayinevi", SqlDbType.VarChar, 100);
            cb.AddField("barkodno", SqlDbType.VarChar, 50);
            cb.AddField("yazari", SqlDbType.VarChar, 50);
            cb.AddField("location", SqlDbType.VarChar, 50);
            cb.AddField("kategori", SqlDbType.VarChar, 50);
            cb.SqlTableName = "tbl_kitap";
            cb.Con = con;
            cb.CreateCommands(daMain);

            daMain.Fill(dtMain);

        }
        private void SaveData()
        {
            gridView1.UpdateCurrentRow();
            daMain.Update(dtMain);
        }

        private void frmBookDefine_Load(object sender, EventArgs e)
        {
            LoadData();
            gridControl1.DataSource = dtMain;
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
