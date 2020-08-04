using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 6, 12, 6, 21, 6, 8, 2, 2, 1};
            Shuffle(ref array);
            foreach (int element in array)
            {
                Console.Write(element+" ");
            }
        }

        static int[] Shuffle(ref int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int someNumber = array[i];
                int position = rand.Next(0, array.Length - 1);
                array[i] = array[position];
                array[position] = someNumber;
            }
            return array;
        }
    }
}
