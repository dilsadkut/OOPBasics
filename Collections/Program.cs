using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

                   
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);

            Console.WriteLine("-----------------------------------------------");
           
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler2[0]);
            //Console.WriteLine(isimler2[1]);
            //Console.WriteLine(isimler2[2]);
            //Console.WriteLine(isimler2[3]);
           

            foreach(string isim in isimler2)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
