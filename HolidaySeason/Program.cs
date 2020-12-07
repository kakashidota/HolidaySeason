using HolidaySeason.Gifts;
using System;
using System.Collections.Generic;

namespace HolidaySeason
{
    class Program
    {

        static List<Human> listOfPersons = new List<Human>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the christmas list thingy");
            Console.WriteLine("What do you wanna do?");
         

        }


        static void Start()
        {

            Console.WriteLine("1. Add person");
            Console.WriteLine("2. Buy gifts");
            Console.WriteLine("3. Calculate stuff");
            Console.WriteLine("4. Show current status");

            int decision = Convert.ToInt32(Console.ReadLine());

            switch (decision)
            {

                case 1:
                    AddPerson();
                    break;
                case 2:
                    BuyGifts();
                    break;
                case 3:
                    Calculate();
                    break;
                case 4:
                    ShowStatus();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }


        }

        static void AddPerson()
        {

            Console.WriteLine("How many do you want to add?");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numberOfPeople; i++)
            {
                bool buyBack = false;

                Console.Write("Enter Firstname: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter secondname: ");
                string secondName = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Willthis person buy you a gift?");
                string answer = Console.ReadLine();
               

                if(answer.Trim().ToLower() == "yes")
                {
                    buyBack = true;
                }

                Console.Write("Relation: ");
                string relation = Console.ReadLine();



                listOfPersons.Add(new Human(firstName, secondName, age, buyBack, relation));
            }


            Start();

        }

        static void BuyGifts()
        {
            bool keepBuying = true;

            while (keepBuying)
            {
                int counter = 1;

                Console.WriteLine("Who do you wanna buy gifts for?");

                foreach(Human person in listOfPersons)
                {
                    Console.WriteLine($"{counter}. {person.FirstName} {person.LastName}");
                    counter++;
                }
                

                int choice = Convert.ToInt32(Console.ReadLine());

                Human personToGift = listOfPersons[choice - 1];

                Console.WriteLine("What do you wanna buy?");
                Console.WriteLine("1. Beauty gifts");
                Console.WriteLine("2. Clothes");
                Console.WriteLine("3. Technology");
                Console.WriteLine("4. Hobby");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Beauty Maskarra = new Beauty();
                        break;
                    case 2:
                        Clothes byxor = new Clothes();
                        break;
                }

                Console.WriteLine("Do you want to continue=? q to quit");
                if(Console.ReadLine() == "q")
                {
                    keepBuying = false;
                    Start();
                }


            }

        }

        static void Calculate()
        {

        }

        static void ShowStatus()
        {

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Console.WriteLine(listOfPersons[i]);
            }

            Start();

        }

    }


}

