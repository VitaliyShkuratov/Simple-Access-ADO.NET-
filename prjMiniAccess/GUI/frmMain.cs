using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMiniAccess.DATA;
using prjMiniAccess.GUI;

namespace prjMiniAccess
{
    public partial class frmMain : Form
    {
        string formName = "Mini Access";
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            createDataBaseForm();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check and if open close data base
            dbCloseDataBase.closeDataBase(dbDataSourse.currentDb);
            // call dialog create new data base
            createDataBaseForm();
        }

        // open create new table windows
        public void createTableForm()
        {
            if (dbDataSourse.currentDb != null)
            {
                frmTable newTableForm = new frmTable();
                newTableForm.MdiParent = this;
                newTableForm.Show();
            }
        }
        // open create new data base window
        private void createDataBaseForm()
        {
            frmEmptyDb newDbForm = new frmEmptyDb(this);
            newDbForm.MdiParent = this;

            // get started position
            int x = this.DesktopBounds.Left + (this.Width - newDbForm.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - newDbForm.Height) / 2;
            newDbForm.Show();
            newDbForm.SetDesktopLocation(x, y);
        }
        // close the database before exit application
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void exitAltXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDataBaseDialog = new OpenFileDialog();
            openDataBaseDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openDataBaseDialog.Filter = "Microsoft Access 2007 - 2016 Databases(*.accdb)|*.accdb|Microsoft Access Databases (2002 - 2003 format) (*.mdb)|*.mdb";
            openDataBaseDialog.FilterIndex = 1;
            openDataBaseDialog.RestoreDirectory = true;

            if (openDataBaseDialog.ShowDialog() == DialogResult.OK)
            {
                dbCloseDataBase.closeDataBase(dbDataSourse.currentDb);
                dbOpenDataBase.openExistingDataBase(openDataBaseDialog.FileName);
                this.Text = formName + " - " + dbGetDataBaseName.getDataBaseName();
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTableForm();
        }

        private void createRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateRelationships newRelationship = new frmCreateRelationships();
            newRelationship.MdiParent = this;
            newRelationship.Show();
        }

        private void displayTableStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createInfoForm();
        }
        public void createInfoForm()
        {
            frmDisplayInf newDisplay = new frmDisplayInf();
            newDisplay.MdiParent = this;
            newDisplay.Show();
        }
    }
}
