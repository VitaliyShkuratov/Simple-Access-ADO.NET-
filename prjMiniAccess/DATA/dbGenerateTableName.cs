namespace prjMiniAccess.DATA
{
    public static class dbGenerateTableName
    {
        public static string generateTableName()
        {
            string header = "table";
            string tableName = "";
            for (int i = 1; i <= 100; i++)
            {
                tableName = header + i;
                if (!dbFindTable.findTable(tableName))
                {
                    break;
                }
            }
            return tableName;
        }
    }
}
