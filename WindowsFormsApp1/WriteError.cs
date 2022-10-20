using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class WriteError
    {
        public static void messogeError(Exception ex)
        {
            string path = "C:\\3 курс\\СУБД\\Laba1\\WindowsFormsApp1\\Error.txt";
        
            string errorText = ex.ToString();

            StreamWriter sw = new StreamWriter(path);
    
            sw.WriteLine(errorText);
            sw.Close();
        }
    }
}
