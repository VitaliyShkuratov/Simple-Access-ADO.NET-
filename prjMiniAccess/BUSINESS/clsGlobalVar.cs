using System.Collections.Generic;

namespace prjMiniAccess.BUSINESS
{
    public static class clsGlobalVar
    {
        public static string fileName = "";
        public static string filePath = "";
        public static string tableName = "";
        // declare global dictionary
        public static Dictionary<string, clsFieldType> fieldsList;

        // declare and instantiate collection of DAO enumerable types
        public static Dictionary<string, object> daoTypesList = new Dictionary<string, object>() {
            { "Integer", (object)DAO.DataTypeEnum.dbInteger },
            { "Big Integer", (object)DAO.DataTypeEnum.dbBigInt },
            { "Binary", (object)DAO.DataTypeEnum.dbBinary },
            { "Boolean", (object)DAO.DataTypeEnum.dbBoolean },
            { "Byte", (object)DAO.DataTypeEnum.dbByte },

            // { "Char", (object)DAO.DataTypeEnum.dbChar }, ODBCDirect workspaces are not supported in Microsoft Access 2013.

            { "Currency", (object)DAO.DataTypeEnum.dbCurrency } ,
            { "Date", (object)DAO.DataTypeEnum.dbDate } ,
            //{ "Decimal", (object)DAO.DataTypeEnum.dbDecimal } , ODBCDirect workspaces are not supported in Microsoft Access 2013.
            { "Double", (object)DAO.DataTypeEnum.dbDouble },

            //{ "Float", (object)DAO.DataTypeEnum.dbFloat }, ODBCDirect workspaces are not supported in Microsoft Access 2013.

            { "GUID", (object)DAO.DataTypeEnum.dbGUID },
            { "Long", (object)DAO.DataTypeEnum.dbLong },
            { "Long Binary", (object)DAO.DataTypeEnum.dbLongBinary },
            { "Memo", (object)DAO.DataTypeEnum.dbMemo },
            // { "Numeric", (object)DAO.DataTypeEnum.dbNumeric }, ODBCDirect workspaces are not supported in Microsoft Access 2013.

            { "Single", (object)DAO.DataTypeEnum.dbSingle },
            { "Text", (object)DAO.DataTypeEnum.dbText },
         // { "Time", (object)DAO.DataTypeEnum.dbTime }, ODBCDirect workspaces are not supported in Microsoft Access 2013.
         // { "Time Stamp", (object)DAO.DataTypeEnum.dbTimeStamp }, sODBCDirect workspaces are not supported in Microsoft Access 2013.
            { "Var Binary", (object)DAO.DataTypeEnum.dbVarBinary } };
    }
}
