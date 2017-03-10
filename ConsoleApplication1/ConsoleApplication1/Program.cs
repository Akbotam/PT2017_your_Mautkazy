using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
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
            for (int i = 0; i < n; i++)
            {  
                int q = int.Parse(ss[i]);
                if (q % 2 == 0)
                {
                    sw.Write(q + " ");
                }
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();

        }
    }
}
