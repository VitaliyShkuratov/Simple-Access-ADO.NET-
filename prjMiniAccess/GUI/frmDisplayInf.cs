using System;
using System.Windows.Forms;
using prjMiniAccess.DATA;

namespace prjMiniAccess.GUI
{
    public partial class frmDisplayInf : Form
    {
        public frmDisplayInf()
        {
            InitializeComponent();
        }

        private void frmDisplayInf_Load(object sender, EventArgs e)
        {
            if (dbDataSourse.currentDb != null)
            {
                lstInfo.Items.Add("Database name: " + dbGetDataBaseName.getDataBaseName());
                foreach (var table in dbGetTablesName.getTablesName())
                {
                    lstInfo.Items.Add("\tTable name: " + table);
                    foreach (var field in dbGetFieldsName.getFieldsName(table))
                    {
                        lstInfo.Items.Add("\t\tField name: " + field);
                    }

                    foreach (var indexedField in dbGetIndexedFieldName.getIndexedFieldName(table))
                    {
                        lstInfo.Items.Add("\t\tIndex name:" + indexedField);
                    }
                }
                foreach (var rel in dbGetRelationName.GetRelationName())
                {
                    lstInfo.Items.Add("\tRelation name: " + rel);
                }
            }
            else lstInfo.Items.Add("Data base does not open");

        }
    }
}
