using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG340
{
    public class Configuration_Parameters
    {
        // By making the default constructor private, it becomes impossible for a 3rd party user to create an object of type Configuration_Parameters without providing a filename
        private Configuration_Parameters()
        {

        }

        //This is the useful Constructor
        public Configuration_Parameters(String configFileName)
        {
            FileStream fs = File.Open(configFileName, FileMode.Open, FileAccess.Read, FileShare.None);
            if(fs == null)
            {
                Console.WriteLine("File cannot be accessed for reading - Aborting\r\n");
            }
            else
            {
                Console.WriteLine("File is available for reading - Continuing\r\n");
            }
        }


        String user;
        String password;
        String host;
        String current_database;

    }
}
