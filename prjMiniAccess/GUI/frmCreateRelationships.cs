using System;
using System.Windows.Forms;
using prjMiniAccess.DATA;

namespace prjMiniAccess.GUI
{
    public partial class frmCreateRelationships : Form
    {
        public frmCreateRelationships()
        {
            InitializeComponent();
        }

        private void frmEditRelationships_Load(object sender, EventArgs e)
        {
            populateTableCmb();
            populateLeftColumnCmb();
            populateRightColumnCmb();
        }
        private void populateTableCmb()
        {
            if (dbGetTablesName.getTablesName() != null)
            {
                cmbLeftTable.DataSource = dbGetTablesName.getTablesName();
                cmbRightTable.DataSource = dbGetTablesName.getTablesName();
            }
            else
            {
                MessageBox.Show("No tables in database. Create tables first.","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void populateLeftColumnCmb()
        {
            // check if value from combobox is empty
            string lestFieldName = ( cmbLeftTable.SelectedItem == null )? "" : cmbLeftTable.SelectedItem.ToString();

            cmbLeftColumn.DataSource = dbGetIndexedFieldName.getIndexedFieldName(lestFieldName);

        }
        private void populateRightColumnCmb()
        {
            // check if value from combobox is empty
           string rightFieldName = ( cmbRightTable.SelectedItem == null ) ? "" : cmbRightTable.SelectedItem.ToString();

            cmbRightColumn.DataSource = dbGetIndexedFieldName.getIndexedFieldName(rightFieldName);

        }
        private void cmbRightTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateRightColumnCmb();
        }

        private void cmbLeftTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateLeftColumnCmb();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // check if fields are chosen
            if (cmbLeftColumn.SelectedItem != null &&
                cmbRightColumn.SelectedItem != null)
            {
                string leftTable = cmbLeftTable.SelectedItem.ToString();
                string rightTable = cmbRightTable.SelectedItem.ToString();
                string leftColumn = cmbLeftColumn.SelectedItem.ToString();
                string rightColumn = cmbRightColumn.SelectedItem.ToString();

                // check if not chosen the same field from the same table
                if (leftTable != rightTable || leftColumn != rightColumn)
                {
                    if ((dbGetFieldDataType.getFieldDataType(leftTable, leftColumn)).Equals(
                        dbGetFieldDataType.getFieldDataType(rightTable, rightColumn)))

                    {
                        dbCreateRelation.createRelation(
                            cmbLeftTable.SelectedItem.ToString(),
                            cmbLeftColumn.SelectedItem.ToString(),
                            cmbRightTable.SelectedItem.ToString(),
                            cmbRightColumn.SelectedItem.ToString());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The field should be the same data type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Cannot create a relationship between a field and itself. Chose different field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No table in database. Create tables","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
