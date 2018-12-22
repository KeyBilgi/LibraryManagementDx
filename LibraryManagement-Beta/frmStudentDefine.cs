using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System.Data.SqlClient;
using LibraryManagement;

namespace LibraryManagement_Beta
{
    public partial class frmStudentDefine : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmStudentDefine()
        {
            InitializeComponent();
            
        }
        DataTable dtMain = null;
        SqlDataAdapter daMain = null;

        private void LoadData()
        {
            dtMain = new DataTable();
            SqlConnection con = new SqlConnection("Server=KEYMM;Database=DbLibraryManagement;User Id=sa;Password=12355;Trusted_Connection=True;");
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.aciklama, a.ad, a.adres, a.babaad, a.cinsiyet, " +
                "a.dtarih, a.mail, a.okul, a.sinif, a.soyad, a.tc, a.tel, a.donem, a.anaad " +
                "from tbl_customer a";

            daMain = new SqlDataAdapter(cmm);
            cCommandBuilder cb = new cCommandBuilder();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("aciklama", SqlDbType.VarChar, 100);
            cb.AddField("ad", SqlDbType.VarChar, 30);
            cb.AddField("adres", SqlDbType.VarChar, 100);
            cb.AddField("anaad", SqlDbType.VarChar, 30);
            cb.AddField("babaad", SqlDbType.VarChar, 30);
            cb.AddField("cinsiyet", SqlDbType.TinyInt, 4);
            cb.AddField("dtarih", SqlDbType.SmallDateTime, 4);
            cb.AddField("mail", SqlDbType.VarChar, 30);
            cb.AddField("okul", SqlDbType.VarChar, 100);
            cb.AddField("sinif", SqlDbType.VarChar, 30);
            cb.AddField("soyad", SqlDbType.VarChar, 30);
            cb.AddField("tc", SqlDbType.VarChar, 30);
            cb.AddField("tel", SqlDbType.VarChar, 30);
            cb.AddField("donem", SqlDbType.VarChar, 50);
            cb.SqlTableName = "tbl_customer";
            cb.Con = con;
            cb.CreateCommands(daMain);

            daMain.Fill(dtMain);

        }
        private void SaveData()
        {
            gridView1.UpdateCurrentRow();
            daMain.Update(dtMain);
        }

        private void frmStudentDefine_Load(object sender, EventArgs e)
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