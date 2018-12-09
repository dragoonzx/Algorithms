using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 6, 3, 8 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                    }
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
