using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint0.Task6.V0.Lib;

namespace Tyuiu.CherepanovVS.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArrey = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numArrey));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(numArrey));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultArray(numArrey));
            Console.ReadKey();
        }
    }
}
