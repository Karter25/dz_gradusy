using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    public class BaseConverter
    {
        int temperature;
        float farengeit;
        int kelvin;

        public int Temperature
        {
            get { return temperature; }

            set
            {
                temperature = value;
            }
        }

        public float Farengeit
        {
            get { return farengeit; }

            set
            {
                farengeit = value - 32 * 5 / 9;
            }
        }

        public int Kelvin
        {
            get { return kelvin; }
            set
            {
                kelvin = value + 273;
            }
        }

        public void Info()
        {
            Console.WriteLine($"Цельсия:{temperature}, Кельвины:{kelvin}, Фаренгейты:{farengeit}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                BaseConverter fg = new BaseConverter();
                fg.Temperature = 1;
                fg.Kelvin = 1;
                fg.Farengeit = 1;
                fg.Info();

                Console.ReadKey();
            }
        }
    }
}
