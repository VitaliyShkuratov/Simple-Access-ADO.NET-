using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbCreateDataBase
    {
        public static void createDatabase(string fileName)
        {
            dbDataSourse.currentDb = dbEngine.getDbEngine().CreateDatabase(fileName, LanguageConstants.dbLangGeneral);

        }

    }
}
