using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob : Gambler
    {
        public SilentBob() : base("SilentBob")
        {
        }

        public override void NewNumber(int number)
        {
            if (!number.IsEven())
                Score++;
        }
    }
}
