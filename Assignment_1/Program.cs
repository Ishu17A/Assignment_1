using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_1
{





    internal class Program6
    {
        static void Main(string[] args)
        {

            /*            Assignment_1*/


            Console.WriteLine("assignment = 1");

            string path = @"D:\file1.txt";


            byte[] readtext = File.ReadAllBytes(path);


            var str = System.Text.Encoding.Default.GetString(readtext);
            Console.WriteLine(str);


            File.WriteAllBytes(@"D:\file3.txt", readtext);




            Console.WriteLine("done");



            Console.ReadLine();



        }
    }
}
