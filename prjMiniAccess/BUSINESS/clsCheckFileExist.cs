using System.IO;

namespace prjMiniAccess.BUSINESS
{
    public static class clsCheckFileExist
    {
        public static bool checkFileExist(string fileName)
        {
            return File.Exists(fileName) ? true : false;
        }
    }
}
