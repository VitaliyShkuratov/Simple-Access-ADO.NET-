using System.Collections.Generic;
using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbGetFieldsName
    {

        public static List<string> getFieldsName(string tableName)
        {
            List<string> fieldsList = new List<string>();
            foreach (TableDef table in dbDataSourse.currentDb.TableDefs)
                {
                    if (table.Name == tableName)
                    {
                        foreach (Field field in table.Fields)
                        {
                            fieldsList.Add(field.Name);
                        }
                    }
            }
            return fieldsList;
        }
    }
}
