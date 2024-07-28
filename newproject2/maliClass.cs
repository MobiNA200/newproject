using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject2
{
    interface hesab
    {
        int hoghogh(int x);
    }
    internal class maliClass:hesab
    {
        public int hoghogh(int x)
        {
            int c = 60000 * x;
            return c;
        }
    }
}
