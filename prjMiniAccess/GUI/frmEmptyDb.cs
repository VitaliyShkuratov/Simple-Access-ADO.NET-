using System;
using System.Drawing;
using System.Windows.Forms;
using prjMiniAccess.BUSINESS;
using prjMiniAccess.DATA;
using System.IO;

namespace prjMiniAccess
{
    public partial class frmEmptyDb : Form
    {
        string defaultPath = "";
        string mainFormName = "Mini Access";
        frmMain parentMain;
        public frmEmptyDb()
        {
            InitializeComponent();
        }
        public frmEmptyDb(frmMain frm)
        {
            InitializeComponent();
            parentMain = frm;
        }
        private void pctClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmptyDb_Load(object sender, EventArgs e)
        {
            defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\";
            txtFileName.Text = clsGetFileDefaultName.getFileDefaultName(defaultPath);
            lblPath.Text = defaultPath;
        }

        private void pctSaveDialog_MouseHover(object sender, EventArgs e)
        {
            pctSaveDialog.BackColor = Color.Beige;
        }
        private void pctSaveDialog_MouseLeave(object sender, EventArgs e)
        {
            pctSaveDialog.BackColor = Color.White;
        }
        private void pctCreate_MouseHover(object sender, EventArgs e)
        {
            pctCreate.BackColor = Color.Beige;
        }

        private void pctCreate_MouseLeave(object sender, EventArgs e)
        {
            pctCreate.BackColor = Color.White;
        }

        private void pctSaveDialog_Click(object sender, EventArgs e)
        {
            choseFile(txtFileName.Text);
            this.Close();
        }

            public void choseFile(string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "File New Database";
            saveFileDialog.Filter =
                    "Microsoft Access 2007 - 2016 Databases(*.accdb)|*.accdb|Microsoft Access Databases (2002 - 2003 format) (*.mdb)|*.mdb";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = fileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                /* dbCreateDataBase.createDatabase(saveFileDialog.FileName);
                 parentMain.createTableForm();
                 parentMain.Text = mainFormName + " - " + dbGetDataBaseName.getDataBaseName();*/

                if (clsCheckFileExist.checkFileExist(saveFileDialog.FileName))
                {
                    if (MessageBox.Show((txtFileName.Text + " already exists.\nDo you want to replace it?"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);
                            dbCreateDataBase.createDatabase(saveFileDialog.FileName);
                            parentMain.Text = mainFormName + " - " + dbGetDataBaseName.getDataBaseName();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cannot overwrite the file. The file could be open by another program.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    dbCreateDataBase.createDatabase(saveFileDialog.FileName);
                    parentMain.Text = mainFormName + " - " + dbGetDataBaseName.getDataBaseName();
                }
                parentMain.createTableForm();
            }
        }

        private void pctCreate_Click(object sender, EventArgs e)
        {
            string filePath = defaultPath + txtFileName.Text;
            if (clsCheckFileExist.checkFileExist(filePath))
            {
                if (MessageBox.Show((txtFileName.Text + " already exists.\nDo you want to replace it?"),"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(filePath);
                        dbCreateDataBase.createDatabase(filePath);
                        parentMain.Text = mainFormName + " - " + dbGetDataBaseName.getDataBaseName();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot overwrite the file. The file could be open by another program.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                dbCreateDataBase.createDatabase(filePath);
                parentMain.Text = mainFormName + " - " + dbGetDataBaseName.getDataBaseName();
            }
            parentMain.createTableForm();
            this.Close();

        }
    }
}
