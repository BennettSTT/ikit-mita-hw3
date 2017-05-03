using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public delegate void NewNumber(int number);

    public class Numbertron
    {
        public event NewNumber GetNumber;

        public void Generate()
        {
            var random = new Random();
            GetNumber?.Invoke(random.Next(1, int.MaxValue));
        }
    }
}
