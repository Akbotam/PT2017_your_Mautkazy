using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Андрей\ PT2017_your_Mautkazy\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Андрей\ PT2017_your_Mautkazy\output.txt");
            string s = sr.ReadLine();
            string[] ss = s.Split();
            int n = ss.Length;
            int[] arr = new int[n];
           int A  = int.Parse(ss[0]);
            int B = int.Parse(ss[1]);
                 if (A < B)
                 {
                     for (int i = 1; i < A; i++)
                     {
                         if (A % i == 0 && B % i == 0)
                         {
                             sw.Write(i + " ");
                         } 
                     }
                 }
                 else
                 {
                     for (int i = 1; i < B; i++)
                     {
                         if (A % i == 0 && B% i == 0)
                         {
                             sw.Write(i + " ");
                         }
                     }

                 }
              


               /* for (int i = 0; i < n; i++)
                 {
                     arr [i] = int.Parse(ss[i]);
               
                 }
                 for (int i = 0; i < n; i++)
                 {
                     if (arr[i] < arr[i + 1])
                     {
                         for (int j = 1; j < arr[i]; j++)
                         {
                             if (arr[i] % j == 0 && arr[i + 1] % j == 0)
                             {
                                 sw.WriteLine(j + " ");
                             }
                         }
                     }
                     else
                     {
                         for (int j = 1; j < arr[i+1]; j++)
                         {
                             if (arr[i] % j == 0 && arr[i + 1] % j == 0)
                             {
                                 sw.WriteLine(j + " ");
                             }
                         }

                     }
                 }  */
                sr.Close();
            sw.Close();
            Console.ReadKey();
           

        }
    }
}
