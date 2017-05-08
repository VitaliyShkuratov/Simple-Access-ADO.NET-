using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbCreateIndex
    {
        static Field currentField = new Field();
        public static void createIndex(TableDef currentTable, string fieldName)
        {
            Index currentIndex = currentTable.CreateIndex(fieldName);
            currentField = currentIndex.CreateField(fieldName);
            ((IndexFields)currentIndex.Fields).Append(currentField);
            currentIndex.Unique = true;
           currentTable.Indexes.Append(currentIndex);
        }
    }
}
