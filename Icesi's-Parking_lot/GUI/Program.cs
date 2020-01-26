using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace GUI
{
    static class Program
    {

        public static LinkedList<Data> registers = new LinkedList<Data>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }

        public static void read()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\data.txt");

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    String[] rd = line.Split(new char[] {','});
                    Data d = new Data(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);
                    registers.AddLast(d);
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

        public static void Write()
        {
            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\data.txt", true);

                //new element
                Data nE = registers.Last.Value;

                sw.WriteLine("\n" + nE.getName() + "," + nE.getLastName() + "," + nE.getLicense() + "," + 
                             nE.getBrand() + "," + nE.getModel() + "," + nE.getColor() + "," + nE.getCareer());

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }

    class Data
    {

        private String name, lastName, license, brand, model, color, career;

       public Data(String nName, String nLastName, String nLicense, String nBrand, String nModel, String nColor, String nCareer)
        {
            name = nName;
            lastName = nLastName;
            license = nLicense;
            brand = nBrand;
            model = nModel;
            color = nColor;
            career = nCareer;
        }

        public String getName()
        {
            return name;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String getLicense()
        {
            return license;
        }

        public String getBrand()
        {
            return brand;
        }

        public String getModel()
        {
            return model;
        }

        public String getColor()
        {
            return color;
        }

        public String getCareer()
        {
            return career;
        }
    }

}
