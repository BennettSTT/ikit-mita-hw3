using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal static class Expansion
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}
