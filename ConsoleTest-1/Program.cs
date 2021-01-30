using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StartMenu();
            }
        }

        private static void StartMenu()
        {

            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Run reference types example");
            Console.WriteLine("2. Run static members example");
            Console.WriteLine("3. Find square root\n");

            ProcessInput(Console.ReadLine());
        }

        private static void ProcessInput(string v)
        {
            try
            {
                v = v.Trim();

                switch (v)
                {
                    case "1":
                        RunReferenceExample();
                        break;
                    case "2":
                        FindSquareRoot();
                        break;
                    default:
                        Console.WriteLine("Incorrect value chosen.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception details:\n" + e.Message + "\n" + e.InnerException);
                Console.WriteLine("\nPress any key to terminate application.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static void FindSquareRoot()
        {
            throw new NotImplementedException();
        }

        private static void RunReferenceExample()
        {
            try
            {
                TestA a = new TestA();
                a.A = 1;

                TestA b = a;
                b.A = 2;

                Console.WriteLine("\nObject Reference Example:");
                Console.WriteLine("TestA = " + a.A);
                Console.WriteLine("TestB = " + b.A + "\n");

                int valueA = 3;
                a.AddTenRef(ref valueA);

                int valueB = 3;
                a.AddTenValue(valueB);

                Console.WriteLine("Method Reference Example:");
                Console.WriteLine("ValueA = " + valueA);
                Console.WriteLine("ValueB = " + valueB + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception details:\n" + e.Message + "\n" + e.InnerException);
                Console.WriteLine("\nPress any key to terminate application.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
