using System;
using System.Collections.Generic;
using System.Windows.Forms;
using prjMiniAccess.BUSINESS;
using prjMiniAccess.DATA;

namespace prjMiniAccess.GUI
{
    public partial class frmTable : Form
    {
        DataGridViewComboBoxColumn cmbDataType;
        DataGridViewComboBoxColumn cmbIndexed;
        frmSaveAs newSaveForm;
        public frmTable()
        {
            InitializeComponent();
            cmbDataType = new DataGridViewComboBoxColumn();
            cmbIndexed = new DataGridViewComboBoxColumn();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            // assign default name for table
            clsGlobalVar.tableName = dbGenerateTableName.generateTableName();
            this.Text = "Create Table: " + clsGlobalVar.tableName;
            populateDataGridView();
        }
        // extract values from datagridview and write it to dictionary fieldList
        public bool getFieldsValue()
        {
            // instantiate new list of fields
            clsGlobalVar.fieldsList = new Dictionary<string, clsFieldType>();

            string firstCellValue = "";
            foreach (DataGridViewRow row in dgvTableFields.Rows)
            {
                // check end of the data grid view
                if (row.Cells[0].Value != null)
                {
                    firstCellValue = row.Cells[0].FormattedValue.ToString();
                    // check if the name of the field already exist
                    if (!clsGlobalVar.fieldsList.ContainsKey(firstCellValue))
                    {
                        clsGlobalVar.fieldsList.Add(firstCellValue,
                                 new clsFieldType(
                                    firstCellValue,
                                    getDataType(row.Cells[1].FormattedValue.ToString()),
                                    getBooleanValue(row.Cells[2].FormattedValue.ToString())));
                    }
                    else
                    {
                        string messageString = "You already have a field named '" + firstCellValue + "'";
                        MessageBox.Show(messageString, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }
            return false;
        }
        // convert to boolean value from cell
        private bool getBooleanValue(string dataName)
        {
            return Convert.ToBoolean(dataName);
        }
        // get value from list of DAO Datatypes
        private object getDataType(string dataName)
        {
            foreach (var item in clsGlobalVar.daoTypesList)
            {
                if (item.Key == dataName)
                {
                    return item.Value;
                }
            }
            return null;
        }
        private void populateDataGridView()
        {
            dgvTableFields.Columns.Add("clmFieldName", "Field Name");

            cmbDataType.HeaderText = "Data Type";
            cmbDataType.Name = "clmDataType";
            populateCmbDataType();
            dgvTableFields.Columns.Add(cmbDataType);

            cmbIndexed.HeaderText = "Indexed";
            cmbIndexed.Name = "clmIndexed";
            populateCmbIndexed();
            dgvTableFields.Columns.Add(cmbIndexed);

        }
        private void populateCmbIndexed()
        {
            cmbIndexed.Items.Add("true");
            cmbIndexed.Items.Add("false");
        }
        private void populateCmbDataType()
        {
            foreach (var key in clsGlobalVar.daoTypesList.Keys)
            {
                cmbDataType.Items.Add(key);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dgvTableFields.Rows[0].Cells[0].FormattedValue.ToString())
                 || String.IsNullOrEmpty(dgvTableFields.Rows[0].Cells[1].FormattedValue.ToString())
                 || String.IsNullOrEmpty(dgvTableFields.Rows[0].Cells[2].FormattedValue.ToString()))

            {
                MessageBox.Show("Enter information for at least one field.");

            }
            else
            {
                if (!getFieldsValue())
                {
                    this.dgvTableFields.ReadOnly = true;
                    if (newSaveForm == null || newSaveForm.IsDisposed)   {
                        newSaveForm = new frmSaveAs(this);
                        newSaveForm.MdiParent = this.ParentForm;
                    }
                    newSaveForm.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.newSaveForm.Close();
        }
    }
}
