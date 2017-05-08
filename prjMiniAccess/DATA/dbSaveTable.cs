using DAO;
using prjMiniAccess.BUSINESS;

namespace prjMiniAccess.DATA
{
    public static class dbSaveTable
    {
        public static void saveTableToDb()
        {
            TableDef currentTable = new TableDef() { Name = clsGlobalVar.tableName };

            foreach (var field in clsGlobalVar.fieldsList)
            {
                currentTable.Fields.Append(currentTable.CreateField(field.Value.FieldName, field.Value.DataType));
                // check if field is indexed
                if (field.Value.Indexed)
                {
                    dbCreateIndex.createIndex(currentTable, field.Value.FieldName);
                }
            }
            dbDataSourse.currentDb.TableDefs.Append(currentTable);
        }
    }
}
