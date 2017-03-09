using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mid
{
    class Program
    {
        /* static void comp(string path)
         {   
             Console.Clear();
         FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
         StreamReader sr = new StreamReader(fs);
         StreamWriter sw = new StreamWriter(fs);
         string s = sr.ReadToEnd();
         if (s == "abcd")
         Console.WriteLine(s);
         sr.Close();
       
         fs.Close();
         Console.ReadKey();

         } */

        static void Main(string[] args)
        {
           /* string s;
            s = Console.ReadLine();
            string[] ss = s.Split();
            int n = ss.Length;

              DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Андрей\ PT2017_your_Mautkazy\Yes");
            FileSystemInfo[] infos = dir.GetFileSystemInfos();
            for (int i = 0; i < dir.GetFileSystemInfos().Length; i++)
            {
                if (infos[i].GetType() == typeof(FileInfo))
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < infos[j].Length; j++)
                        {
                            if (ss[i] == infos[j].Name)
                            {
                                Console.WriteLine(infos[i].FullName);
                            }
                        }
                    }
                    }
                } */

            StreamReader sr = new StreamReader(Console.ReadLine());
            string s = sr.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(s);
            FileSystemInfo[] infos = dir.GetFileSystemInfos();
            for (int i = 0; i < dir.GetFileSystemInfos().Length; i++)
            {
                if (infos[i].GetType() == typeof(FileInfo))
                {
                    FileStream fs = new FileStream(infos[i].FullName, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader sr = new StreamReader(fs);
                    string s = sr.ReadToEnd();
                    if (s == "test")
                    {

                        Console.WriteLine(infos[i].FullName);
                    }
                }
               /* else
                {
                    FileStream fs = new FileStream(infos[i].FullName, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader sr = new StreamReader(fs);
                    string s = sr.ReadToEnd();
                    if (s == "test")
                    {

                        Console.WriteLine(infos[i].FullName);
                    }

                } 
                */
            }

            Console.ReadKey();


        }
    }
}
