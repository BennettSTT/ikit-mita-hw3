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
        private readonly Random _random = new Random();

        public void Generate()
        {
            GetNumber?.Invoke(_random.Next(int.MaxValue));
        }
    }
}
