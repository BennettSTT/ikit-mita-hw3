using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ikit_mita_hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                Console.WriteLine("Сколько нужно чисел для решения спора?");
                Console.Write("Решение: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    continue;
                }

                if (number > 0)
                    break;
                Console.WriteLine("Введеное вами число не подходит :с Попробуйте еще раз");
                Console.WriteLine();
            }
            Console.WriteLine();

            var numbertron = new Numbertron();
            var jay = new Jay();
            var silentBob = new SilentBob();

            numbertron.GetNumber += jay.NewNumber;
            numbertron.GetNumber += silentBob.NewNumber;

            for (var i = 0; i < number ; i++)
            {
                numbertron.Generate();
            }

            if (jay.Score > silentBob.Score)
                Console.WriteLine("Jay VIN");
            else if (jay.Score < silentBob.Score)
                Console.WriteLine("SilentBob VIN");
            else if (jay.Score == silentBob.Score)
                Console.WriteLine("DRAW");

            Console.ReadKey();
        }
    }
}
