using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs");
            Console.WriteLine("1.Permutation\n2.Binary Search Word ");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Permutation permutation = new Permutation();
                    String str = "ABC";
                    int n = str.Length;
                    permutation.permute(str, 0, n - 1);
                    break;
                case 2:
                    BinarySearchWord searchWord = new BinarySearchWord();
                    String[] arr = { "contribute", "geeks", "ide", "practice" };
                    String x = "ide";
                    int result = searchWord.binarySearch(arr, x);

                    if (result == -1)
                        Console.WriteLine("Element not present");
                    else
                        Console.WriteLine("Element found at "
                                        + "index " + result);
                    break;
            }
        }
    }
}
