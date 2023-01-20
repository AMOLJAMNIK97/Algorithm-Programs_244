using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void bubbleSort(int[] arr1, int m)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < m - 1; i++)
            {
                swapped = false;
                for (j = 0; j < m - i - 1; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }

        public void printArray(int[] arr1, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
        }
    }
}
