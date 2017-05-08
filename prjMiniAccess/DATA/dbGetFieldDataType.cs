using DAO;

namespace prjMiniAccess.DATA
{
    public static class dbGetFieldDataType
    {
        public static DataTypeEnum getFieldDataType(string tableName, string fieldName)
        {
            DataTypeEnum currentType = new DataTypeEnum();
            foreach (TableDef table in dbDataSourse.currentDb.TableDefs)
            {
                if (table.Name == tableName)
                {
                    foreach (Field field in table.Fields)
                    {
                        if (field.Name == fieldName)
                        {
                            currentType = (DataTypeEnum)field.Type;
                            break;
                        }
                    }
                }
            }
            return currentType;
        }
    }
}
