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

        }

        private void mnOgrenciTanımlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStudentDefine fuser = new frmStudentDefine();
            fuser.MdiParent = this;
            fuser.Show();
        }
    }
}
