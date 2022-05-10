using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descending_order_10_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter the value :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < 7; j++)
            {
                Console.Write(" " + arr[j]);
            }
            Console.WriteLine();
            Console.WriteLine("My array :");

            int temp;
            for (int P = 0; P < 7; P++)
            {
                for (int O = 0; O < 7; O++)
                {
                    if (arr[O] < arr[P])
                    {
                        temp = arr[P];
                        arr[P] = arr[O];
                        arr[O] = temp;
                    }
                }

            }
            for (int t = 0; t < 7; t++)
            {
                Console.Write(" " + arr[t]);
            }
        }
    }
}
