using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {

        public static void insertSort(ref int [] array)
        {

            int swap;
            for (int i = 1; i < array.Length; i++)
            {

                for (int j = i; j > 0; j--)
                {
                    if(array[j-1] > array[j])
                    {
                        swap = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = swap;
                    }

                }

            }
        }
        static void Main(string[] args)
        {

            int[] array = new int[] { 5, 15, 15, 24, 11, 55, 4, 1, 74, 157, 23 };

            insertSort(ref array);

            foreach (int elem in array)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}
