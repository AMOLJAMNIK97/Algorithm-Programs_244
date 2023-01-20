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
            Console.WriteLine("1.Permutation\n2.Binary Search Word\n3.Insertion Sort word\n4.Bubble Sort\n5.Merge Sort\n6.Anagram Detections\n7.Prime Number ");
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
                case 3:
                    InsertionSort sortword = new InsertionSort();
                    string[] names = { "Raju ", "Shayam ", "Baburao Ganptrao wapte", "Gabbar sing" };
                    sortword.InsertSort(names);
                    foreach (var item in names)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    BubbleSort bubble = new BubbleSort();
                    int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
                    int m = arr1.Length;
                    bubble.bubbleSort(arr1, m);
                    Console.WriteLine("Sorted array");
                    bubble.printArray(arr1, m);
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    int[] B = { 2, 3, 8, -1, 7, 10 };
                    int z = B.Length;
                    mergeSort.mergeTwoHalf(B, z);
                    for (int i = 0; i < z; i++)
                    {
                        Console.Write(B[i] + " ");
                    } 
                    break;
                case 6:
                    AnagramDetections detections = new AnagramDetections();
                    detections.DetectingAnagrams();
                    break;
                case 7:
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeNum();
                    break;
            }
        }
    }
}
