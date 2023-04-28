using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Arab_v
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("");
            Console.WriteLine("||#######################||");
            Console.WriteLine("||---Welcome to Arab-v---||");
            Console.WriteLine("||-----------------------||");
            Console.WriteLine("||Simple Operating System||");
            Console.WriteLine("||-----------------------||");
            Console.WriteLine("||#######################||");
            Console.WriteLine("");


        }

        protected override void Run()
        {
            string input;

            input = Console.ReadLine();

            Has(input);

        }

        private void Has(string input)
        {

            if (input == "about")
            {
                Console.WriteLine("Arab-v 1.00");
            }

            else if (input == "whoami")
            {
                Console.WriteLine("ibrahim");
            }

            else if (input == "reboot")
            {
                Console.WriteLine("[+] reboot");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                }


                Sys.Power.Reboot();
            }

            else if (input == "power off")
            {
                Console.WriteLine("[+] power off");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);
                }
                Sys.Power.Shutdown();
            }

            else if (input == "help")
            {
                Console.WriteLine("about -- name and version Operating System");
                Console.WriteLine("whoami -- user name");
                Console.WriteLine("reboot -- restart Arab-v");
                Console.WriteLine("power off -- shutdown Arab-v");
            }

            Console.WriteLine();
        }
    }
}
