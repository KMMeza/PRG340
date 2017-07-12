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

        }


        String user;
        String password;
        String host;
        String current_database;

    }
}
