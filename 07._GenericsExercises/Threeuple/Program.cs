using System;
using System.Text;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split();
            var name = personInfo[0] + " " + personInfo[1];
            var street = personInfo[2];
            var town = new StringBuilder();
                town.Append(personInfo[3]);
            if (personInfo.Length > 4)
            {
                town.Append($" {personInfo[4]}");
            }

            string[] personBeerInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.None);
            bool isDrunk = personBeerInfo[2] == "not" ? false : true;
            isDrunk = personBeerInfo[2] == "drunk" ? true: false;



            string[] accountBank = Console.ReadLine()
                .Split(" ",StringSplitOptions.None);
            

            var personThreeuple = new Threeuple<string, string, StringBuilder>(name, street, town);

            var personBeerThreeuple = new Threeuple<string, int, bool>(personBeerInfo[0], int.Parse(personBeerInfo[1]), isDrunk);
            
            var accountBankThreeuple = new Threeuple<string, double,string>(accountBank[0], double.Parse(accountBank[1]), accountBank[2]);

            Console.WriteLine(personThreeuple.GetInfo());
            Console.WriteLine(personBeerThreeuple.GetInfo());
            Console.WriteLine(accountBankThreeuple.GetInfo());
        }
    }
}
