using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileManager.Helper
{
    public class PathHelper
    {
        public static string defaultSysPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string defaultRemovablePath = @"Z:";
    }
}
