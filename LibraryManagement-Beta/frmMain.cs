using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement_Beta
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnKitapTanımlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBookDefine fbook = new frmBookDefine();
            fbook.MdiParent = this;
            fbook.Show();
        }

        private void mnOgrenciTanımlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStudentDefine fuser = new frmStudentDefine();
            fuser.MdiParent = this;
            fuser.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cons.setConnectionString();
        }

        private void mnKitapHar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIssueBook fbook = new frmIssueBook();
            fbook.MdiParent = this;
            fbook.Show();
        }

        private void mnLocationDefine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLokasyonDefine f = new frmLokasyonDefine();
            f.MdiParent = this;
            f.Show();
        }
    }
}
