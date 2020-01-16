using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            var arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var spartans = new Stack<int>(arr1.Reverse());
            for (int i = 1; i <= numberOfWaves; i++)
            {
                var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                var trojans = new Stack<int>(arr);
                if (i % 3 == 0)
                {
                    var queue = new Stack<int>(spartans);
                    queue.Push(int.Parse(Console.ReadLine()));
                    spartans = new Stack<int>(queue);
                }

                

                while (spartans.Count > 0 && trojans.Count > 0)
                {
                    var spartan = spartans.Peek();
                    var trojan = trojans.Peek();

                    trojans.Pop();
                    spartans.Pop();

                    if (spartan > trojan)      // WAR
                    {
                        
                        spartans.Push(spartan - trojan);
                    }
                    else if (trojan > spartan)
                    {
                        trojans.Push(trojan - spartan);
                    }
                }
                
                if (spartans.Count == 0)
                {
                    Console.WriteLine($"The Trojans successfully destroyed the Spartan defense.");
                    if (trojans.Count > 0)
                    {
                        Console.WriteLine($"Warriors left: {String.Join(", ", trojans)}");
                    }

                    return;
                }
            }
            Console.WriteLine($"The Spartans successfully repulsed the Trojan attack.");

            if (spartans.Count > 0)
            {
                Console.WriteLine($"Plates left: {String.Join(", ", spartans)}");
            }
        }
    }
}
