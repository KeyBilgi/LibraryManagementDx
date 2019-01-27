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
using LibraryManagement;

namespace LibraryManagement_Beta
{
    public partial class frmLokasyonDefine : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmLokasyonDefine()
        {
            InitializeComponent();
        }
        DataTable dtMain = null;
        SqlDataAdapter daMain = null;

        private void ribbonControl1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(e.Item.Name)
            {
                case "save":
                    SaveData();
                    break;
                case "saveclose":
                    SaveData();
                    this.Close();
                    break;
                case "close":
                    this.Close();
                    break;
            }
        }
        private void LoadData()
        {
            dtMain = new DataTable();
            SqlConnection con = new SqlConnection(cons.getConnectionString());
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "SELECT a.id, a.kod, a.aciklama " +
                "FROM tbl_location a";

            daMain = new SqlDataAdapter(cmm);
            cCommandBuilder cb = new cCommandBuilder();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("kod", SqlDbType.VarChar, 30);
            cb.AddField("aciklama", SqlDbType.VarChar, 300);
            cb.SqlTableName = "tbl_location";
            cb.Con = con;
            cb.CreateCommands(daMain);

            daMain.Fill(dtMain);
            dtMain.Columns["kod"].AllowDBNull = false;
            dtMain.Columns["kod"].Unique = true;

            gridControl1.DataSource = dtMain;

        }
        
        private void SaveData()
        {
            daMain.Update(dtMain);
        }
        private void frmLokasyonDefine_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
