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
            Console.WriteLine("1.Permutation ");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Permutation permutation = new Permutation();
                    String str = "ABC";
                    int n = str.Length;
                    permutation.permute(str, 0, n - 1);
                    break;
            }
        }
    }
}
