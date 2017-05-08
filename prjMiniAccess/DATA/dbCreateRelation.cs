using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbCreateRelation
    {
        static Field currentField = new Field();
        public static void createRelation(string leftTable, string leftColumn,
            string rightTable, string rightColumn)
        {
            string relName = "fk_" + leftColumn + "_" + rightColumn;
            Relation currentRel = dbDataSourse.currentDb.CreateRelation(relName, leftTable, rightTable);
            currentField = currentRel.CreateField(leftColumn);
            currentField.ForeignName = rightColumn;
            currentRel.Fields.Append(currentField);
            dbDataSourse.currentDb.Relations.Append(currentRel);
        }
    }
}
