using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ввидите количество элементов в массиве: \t");

            int nummassive = Convert.ToInt32(Console.ReadLine());

            int[] myArray;

            myArray = new int[nummassive];

            for (int i = 0; i < myArray.Length; i++)
            {

                Console.Write($"Ввидите значение для элемента № {i}: ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());

            }




            Console.ReadKey();

        }
    }
}
