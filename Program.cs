using System;
using System.Collections;
using System.Collections.Generic;

namespace InheritanceStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var enemy = new Enemy();

            player.TakeDamage(5);

            player.TakeDamage(5);

            SomeMethod(player);
            SomeMethod(enemy);

            MoveTo(player);

            List<int> someList = new List<int>();
            someList.Add(5);
            someList.Add(10);

            Dictionary<string, int> someDict = new Dictionary<string, int>();
            someDict.Add("Hello", 10);
            someDict.Add("Goodbye", 202024);

            Queue<decimal> queue = new Queue<decimal>();
            queue.Enqueue(5m);
            queue.Enqueue(242m);

            IterateThrough(someList);
            IterateThrough(someDict);
            IterateThrough(queue);
        }

        private static void SomeMethod(Mob someMob)
        {
            // does stuff
        }

        private static void MoveTo(ICoordinatable coordinatable)
        {
            coordinatable.XCoord = coordinatable.XCoord + 5;
            coordinatable.YCoord = coordinatable.YCoord + 5;
        }

        private static void IterateThrough(IEnumerable enumerable)
        {
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"Element is: {enumerator.Current}");
            }
        }
    }
}
