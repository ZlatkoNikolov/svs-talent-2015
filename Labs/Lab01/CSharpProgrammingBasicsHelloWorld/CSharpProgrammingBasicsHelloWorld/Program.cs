using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CSharpProgrammingBasicsHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Press Enter to start execution…");
            System.Console.ReadLine();
            //TODO napisi kod za hello world
            //Console.WriteLine("hello world");

            /*for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("{0}.{1}",i,"Hello world");
            }*/

            //int i = 0;
            //while (i<10)
            //{
            //    System.Console.WriteLine("{0}.{1}",i,"Hello worlD");
            //    i++;
            //}

            int ind = 0;
            string maxNumberOfArgumentsStr = ConfigurationManager.AppSettings["MaxNumberOfArguments"];
            int maxNumberOfArguments = Int32.Parse(maxNumberOfArgumentsStr);
            //foreach (var item in args)
            //{
            //    Console.WriteLine("Arg["+ind+"]="+args[ind]);
            //    ind++;
            //}

            if (args.Length > maxNumberOfArguments)
            {
                throw (new ApplicationException("Maximum number of arguments is exceeded."));
            }
            else
            {
                Console.WriteLine(maxNumberOfArguments);
            }

            //System.Console.ReadLine();

        }
    }
}
