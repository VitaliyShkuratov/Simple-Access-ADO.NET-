using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMiniAccess.BUSINESS
{
    public static class clsGetFileDefaultName
    {
        public static string getFileDefaultName(string defaultPath)
        {
            string fileName = "Database.accdb";
            if (clsCheckFileExist.checkFileExist(defaultPath + fileName))
            {
                for (int i = 1; i <= 100; i++)
                {
                    fileName = "Database" + i + ".accdb";
                    if (!clsCheckFileExist.checkFileExist(defaultPath + fileName))
                        break;
                }
            }

            return fileName;
        }
    }
}
