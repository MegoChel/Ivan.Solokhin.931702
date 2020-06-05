using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RandGen
    {
        static Random rnd = new Random();
        public int val1;
        public int val2;
        public int add;
        public int sub;
        public int div;
        public int mul;
        public RandGen()
        {
            val1 = rnd.Next(0, 10);
            val2 = rnd.Next(0, 10);
            add = val1 + val2;
            sub = val1 - val2;
            if (val2 != 0)
            {
                div = val1 / val2;
            }
            else { div = -1; }
            mul = val1 * val2;
        }
    }
}
