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
            TestA a = new TestA();
            a.A = 1;

            TestA b = a;
            b.A = 2;

            Console.WriteLine("Object Reference Example:");
            Console.WriteLine("TestA = " + a.A);
            Console.WriteLine("TestB = " + b.A + "\n");

            int valueA = 3;
            a.AddTenRef(ref valueA);

            int valueB = 3;
            a.AddTenValue(valueB);

            Console.WriteLine("Method Reference Example:");
            Console.WriteLine("ValueA = " + valueA);
            Console.WriteLine("ValueB = " + valueB);

            Console.ReadLine();
        }
    }

    public class TestA
    {
        public TestA()
        {
        }

        public int A { get; set; }

        public static int B { get; set; }

        public void AddTenRef(ref int value)
        {
            value = value + 10;
        }

        public int AddTenValue(int value)
        {
            value = value + 10;
            return value;
        }
    }
}
