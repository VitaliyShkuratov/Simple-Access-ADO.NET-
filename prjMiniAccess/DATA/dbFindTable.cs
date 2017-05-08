using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbFindTable
    {
        public static bool findTable(string tableName)
        {
            foreach (TableDef table in dbDataSourse.currentDb.TableDefs)
            {
                if (table.Name == tableName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
