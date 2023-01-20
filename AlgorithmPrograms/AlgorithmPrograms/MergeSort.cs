using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSort
    {
        public void mergeTwoHalf(int[] B, int z)
        {
            int half_i = 0;
            // starting index of second half
            int i;

            // Temp Array store sorted resultant array
            int[] temp = new int[z];


            // First Find the point where array is divide
            // into two half
            for (i = 0; i < z - 1; i++)
            {
                if (B[i] > B[i + 1])
                {
                    half_i = i + 1;
                    break;
                }
            }

            // If Given array is all-ready sorted
            if (half_i == 0)
                return;

            // Merge two sorted arrays in single sorted
            // array
            i = 0; int j = half_i; int k = 0;
            while (i < half_i && j < z)
            {
                if (B[i] < B[j])
                {
                    temp[k++] = B[i++];
                }
                else
                {
                    temp[k++] = B[j++];
                }
            }
            // Copy the remaining elements of A[i to half_!]
            while (i < half_i)
            {
                temp[k++] = B[i++];
            }
            // Copy the remaining elements of A[half_!
            // to n]
            while (j < z) 
            { 
                temp[k++] = B[j++];
            }

            for (i = 0; i < z; i++) 
                B[i] = temp[i];
        }
    }
}
