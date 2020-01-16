using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int countToReload = int.Parse(Console.ReadLine());

            var arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var bullets = new Stack<int>(arr1);

            var arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)       
                .ToArray();
            var locks = new Queue<int>(arr2);

            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int shooterCount = 0;
            int bulletCount = 0;

            while (bullets.Count != 0)
            {
                
                
                if (shooterCount == countToReload)
                {
                    Console.WriteLine("Reloading!");
                    shooterCount = 0;
                }
                if (locks.Count == 0)
                {
                    break;
                }
                int bullet = bullets.Pop();
                while (locks.Count != 0)
                {
                    int currentLock = locks.Peek();
                    if (bullet<=currentLock)
                    {
                        locks.Dequeue();
                        shooterCount++;
                        bulletCount++;
                        Console.WriteLine("Bang!");
                        break;
                    }
                    else
                    {
                        shooterCount++;
                        bulletCount++;
                        Console.WriteLine("Ping!");
                        break;
                    }
                }
                
                
                
            }
            if (locks.Count>0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence - (bulletCount * priceOfBullet)}");
            }
            

        }
    }
}
