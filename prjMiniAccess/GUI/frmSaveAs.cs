using System;
using System.Windows.Forms;
using prjMiniAccess.BUSINESS;
using prjMiniAccess.DATA;

namespace prjMiniAccess.GUI
{
    public partial class frmSaveAs : Form
    {
        frmTable myParent;

        public frmSaveAs()
        {
            InitializeComponent();
        }

        public frmSaveAs(frmTable frm)
        {
            InitializeComponent();
            myParent = frm;
        }

        private void frmSaveAs_Load(object sender, EventArgs e)
        {
            txtTableName.Text = clsGlobalVar.tableName;
        }
        public void btnOk_Click(object sender, EventArgs e)
        {
            clsGlobalVar.tableName = txtTableName.Text;
            dbSaveTable.saveTableToDb();
            myParent.Close();
            this.Close();
        }
        // create event close active form
        private void closeTableForm(object sender, EventArgs arg)
        {
            myParent.Close();
        }
        // create event to disable form
        private void desactivateForm(object sender, EventArgs arg)
        {
            frmTable.ActiveForm.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.myParent.dgvTableFields.ReadOnly = false;
            this.Close();
        }
    }
}
