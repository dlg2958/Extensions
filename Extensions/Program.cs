using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "1":
                        new ExtensionTutorial();
                        break;
                    case "2":
                        new DelegateTutorial();
                        break;
                    default:
                        /* Put your shapes code here */
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
