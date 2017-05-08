using System.Collections.Generic;
using DAO;


namespace prjMiniAccess.DATA
{
    public static class dbGetTablesName
    {
        public static List<string> getTablesName ()
        {
            List<string> tableList = new List<string>();
                foreach (TableDef table in dbDataSourse.currentDb.TableDefs)
                {
                    // check if table is system
                    if (table.Attributes == 0)
                    {
                        tableList.Add(table.Name);
                    }

                }
            return tableList;
        }
    }
}
