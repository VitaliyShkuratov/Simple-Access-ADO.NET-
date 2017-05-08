namespace prjMiniAccess.DATA
{
    public static class dbGetDataBaseName
    {
        public static string getDataBaseName()
        {
            return (dbDataSourse.currentDb != null) ? dbDataSourse.currentDb.Name : "";
        }
    }
}
