using System.Collections.Generic;
using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbGetRelationName
    {
        public static List<string> GetRelationName()
        {
            List<string> relationList = new List<string>();
            foreach (Relation rel in dbDataSourse.currentDb.Relations)
            {
                relationList.Add(rel.Name.ToString());
            }
            return relationList;
        }
    }
}
