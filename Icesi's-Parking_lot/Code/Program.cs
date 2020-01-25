using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //lectura();
            //escritura();
        }

        public static void lectura()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\ejemplo.txt");

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                sr.Close();
                //Console.ReadLine();
                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void escritura()
        {
            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\data.txt", true);

                sw.WriteLine("Paco,Velez,AGT007,Audi,2015,Blue,Sistemas");
                sw.WriteLine("Augusto,Mercedez,SEX000,Mazda,2010,Red,Economia");

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
