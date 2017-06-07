using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibraryProject;

namespace LogTestingProject {
    class Program {

        static void Main(string[] args) {

            LogCollection.Logger("The component worked!");
            LogCollection.Logger("The component worked again!");
            LogCollection.Logger("The component worked again and again!");

            int i = 1;

        }
    }
}
