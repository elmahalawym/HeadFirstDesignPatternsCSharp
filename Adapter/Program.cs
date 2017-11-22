using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Ducks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //DuckTestDrive();
            TurkeyTestDrive();
        }

        private static void DuckTestDrive()
        {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }

        private static void TurkeyTestDrive()
        {
            IDuck duck = new MallardDuck();
            ITurkey duckAdapter = new DuckAdapter(duck);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }
        }
    }
}
