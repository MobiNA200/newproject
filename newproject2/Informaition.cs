using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject2
{
    internal class Informaition
    {
        StreamReader sr = new StreamReader("C:\\Users\\Windows\\files\\csharpp2.txt");
        public string userType = "";
        public string userName = "";
        public string password = "";
        public string nationalCode = "";
        public string carModel = "";
        public string carPlate = "";
    }
}
