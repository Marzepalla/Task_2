using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            List<int> listOfDividers = Int32.Parse(Console.ReadLine()).GetListOfDividers();

            Console.WriteLine("Целочисленные делители введённого числа:");
            foreach (int elem in listOfDividers)
            {
                Console.WriteLine(elem);
            }
        }
    }
   
}
