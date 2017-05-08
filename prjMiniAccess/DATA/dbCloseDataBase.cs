using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbCloseDataBase
    {
        public static void closeDataBase (Database currentDataBase)
        {
            // check if the data base was open previously
           if (currentDataBase != null )
            {
                currentDataBase.Close();
            }
        }
    }
}
