using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WGU_C969_AM
{
    class Log
    {
        public static void userLoginLog (int userId)
        {
            string path = "log.text";
            string log = $"User with ID of {userId} logged in at {Data.createTimestamp()}" + Environment.NewLine;

            File.AppendAllText(path, log);
        }
    }
}
