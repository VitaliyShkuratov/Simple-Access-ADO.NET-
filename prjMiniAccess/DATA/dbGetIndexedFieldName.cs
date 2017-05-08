using System.Collections.Generic;
using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbGetIndexedFieldName
    {
        public static List<string> getIndexedFieldName(string tableName)
        {
            List<string> fieldsList = new List<string>();
            foreach (TableDef table in dbDataSourse.currentDb.TableDefs)
            {
                if (table.Name == tableName)
                {
                    foreach (Index index in table.Indexes)
                    {
                        fieldsList.Add(index.Name);
                    }
                }
            }
            return fieldsList;
        }
    }
}
