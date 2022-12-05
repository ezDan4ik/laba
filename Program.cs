using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {  
        public static string NumberFormatInfo { get; private set; }

        static void Main(string[] args)
        {
            string str = "1";
            int a;
            bool result = int.TryParse(str, out a);
            if (result)
            {
                Console.WriteLine("Операция успешна");
            }
            else
            {
                Console.WriteLine("Не удалось (");
            }
        }
    }
}
