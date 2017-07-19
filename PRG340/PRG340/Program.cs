using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG340
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration_Parameters param = new Configuration_Parameters("config.txt");
            Utilities.UnitTest();
            Console.Read();
        }
    }
}
