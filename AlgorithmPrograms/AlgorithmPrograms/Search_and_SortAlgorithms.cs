using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Search_and_SortAlgorithms
    {
        public int LinearSearch(ref int[] x, int valueToFind)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (valueToFind == x[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void DisplayElements(ref int[] xArray, char status, string sortname)
        {
            if (status == 'a')
                Console.WriteLine("After sorting using algorithm: " + sortname);
            else
                Console.WriteLine("Before sorting");
            for (int i = 0; i <= xArray.Length - 1; i++)
            {
                if ((i != 0) && (i % 10 == 0))
                    Console.Write("\n");
                Console.Write(xArray[i] + " ");
            }
            Console.ReadLine();
        }

        public void MixDataUp(ref int[] x, Random rdn)
        {
            for (int i = 0; i <= x.Length - 1; i++)
            {
                x[i] = (int)(rdn.NextDouble() * x.Length);
            }
        }
    }
}
