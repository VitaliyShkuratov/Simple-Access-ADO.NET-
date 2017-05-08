namespace prjMiniAccess.DATA
{
    public static class dbOpenDataBase
    {
        public static void openExistingDataBase(string fileName)
        {
            dbDataSourse.currentDb = dbEngine.getDbEngine().OpenDatabase(fileName);
        }
    }
}
