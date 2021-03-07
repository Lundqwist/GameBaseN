using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    static class Debugging
    {
        public static bool isDebugging;



        public static void Show(string printThis)
        {
            if(isDebugging)
            {
                System.Diagnostics.Debug.WriteLine(printThis);

            }
        }




    }
}
