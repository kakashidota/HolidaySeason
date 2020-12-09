using HolidaySeason.Gifts;
using System;
using System.Collections.Generic;

namespace HolidaySeason
{

    //DETTA ÄR DET SISTA NI GÖR
    //TODO: Bryt ut allt härifrån till sin egna klass
    //TODO: Main skall innehålla en klass som kör hela programmet. Tex Logic logic = new Logic(); logic.Run

  

    class Program
    {
        //Skapar en lista av typen Human
        static List<Human> listOfPersons = new List<Human>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the christmas list thingy");
            Console.WriteLine("What do you wanna do?");
            Start();

        }

        //startar programmet
        //TODO: Lägg till en ny metod som heter Önskelista. 
        static void Start()
        {
            bool keepGoing = true;

            while (keepGoing)
            {

                Console.WriteLine("1. Add person");
                Console.WriteLine("2. Buy gifts");
                Console.WriteLine("3. Calculate stuff");
                Console.WriteLine("4. Show current status");
                Console.WriteLine("5. GodMode");
                Console.WriteLine("6. Quit application");

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
                    case 5:
                        GodMode();
                        break;
                    case 6:
                        keepGoing = false;
                        Console.WriteLine("Good bye friend");
                        break;
                    //TODO: Lägg till ett case för önskelista och kalla på metod
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }

            }

        }

        //Lägger till Mockdata i programmet så man inte behöver fylla i det varje gång
        //TODO: Modifera denna godmode så den funkar i ert program. 
        //TODO: Efter godmode skall programmets alla funktioner funka
        static void GodMode()
        {
            Human Yuna = new Human("Yuna", "Kamo", 5, false, "Dotter");
            Human Klaidia = new Human("Klaudia", "Sawicka", 35, true, "Sambo");
            Human Ronja = new Human("Ronja", "Kamo", 2, false, "Dotter");
            listOfPersons.Add(Yuna);
            listOfPersons.Add(Klaidia);
            listOfPersons.Add(Ronja);

            listOfPersons[0].ListOfGifts.Add(new Beauty("pink", "Red", 199, "Loreal something something"));
            listOfPersons[0].ListOfGifts.Add(new Beauty("pink", "Red", 199, "Loreal something something"));
            listOfPersons[0].ListOfGifts.Add(new Beauty("pink", "Red", 199, "Loreal something something"));
            listOfPersons[1].ListOfGifts.Add(new Beauty("pink", "Red", 199, "Loreal something something"));
            listOfPersons[1].ListOfGifts.Add(new Beauty("pink", "Red", 199, "Loreal something something"));
            listOfPersons[2].ListOfGifts.Add(new Beauty("pink", "Red", 199, "Loreal something something"));


            Console.WriteLine("Added mock data");
        }

        //Skapar upp ett objekt av Klassen Human med användarinput
        //TODO: Lägg till olika typer av Humans
        static void AddPerson()
        {

            Console.WriteLine("How many do you want to add?");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
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

                //Modifierar svaret till yes även om de skrivit Yes, Y eS, yES, Y eS etc
                if (answer.ToLower().Replace(" ", "") == "yes")
                {
                    buyBack = true;
                }

                Console.Write("Relation: ");
                string relation = Console.ReadLine();

                //Lägger till i listan av personer som är globlat deklarerad
                listOfPersons.Add(new Human(firstName, secondName, age, buyBack, relation));
            }


        }


        //Skapar upp objekt av Klassen ChirstmasGifts
        //TODO: Bygg ut på switchen så att man kan köpa passande julklappar
        static void BuyGifts()
        {
            bool keepBuying = true;

            while (keepBuying)
            {
                int counter = 1;

                Console.WriteLine("Who do you wanna buy gifts for?");

                foreach (Human person in listOfPersons)
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
                Console.WriteLine("4. Toy");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Beauty Maskarra = new Beauty("Pink", "Glossy glowing black", 199, "Loreal, you is worth it:)");
                        personToGift.ListOfGifts.Add(Maskarra);
                        Console.WriteLine($"Added a {Maskarra.Name} to the list");
                        break;
                    case 2:
                        Clothes byxor = new Clothes("Jeans", "Levis", "30/34", 999, "Levis UltraSlim 2020 Limited Edition");
                        personToGift.ListOfGifts.Add(byxor);
                        Console.WriteLine($"Added a {byxor.Name} to the list");

                        break;
                    case 3:
                        Technology techy = new Technology(6, true, "Samsung Ultra lazer hair remover", 1999, "lifesaver");
                        personToGift.ListOfGifts.Add(techy);
                        Console.WriteLine($"Added a {techy.Name} to the list");
                        break;
                    case 4:
                        Toys toy = new Toys(3, "Peppa pigs magic train", 899, "Kids");
                        personToGift.ListOfGifts.Add(toy);
                        Console.WriteLine($"Added a {toy.Name} to the list");
                        break;
  

                }

                Console.WriteLine("Do you want to continue=? q to quit");
                if (Console.ReadLine() == "q")
                {
                    keepBuying = false;

                }


            }

        }

        //TODO: Skriv ut summan för familj, vänner och släkt. Uppdelat i "Rubriker"
        static void Calculate()
        {
            int sum = 0;

            foreach(Human person in listOfPersons)
            {
                foreach(ChristmasGifts gift in person.ListOfGifts)
                {
                    sum += gift.Price;
                }
            }

            Console.WriteLine("The totalt cost is " + sum);
            

        }


        //TODO: Visa status på alla medlemmar i programmet. Uppdelat i "Rubriker"
        static void ShowStatus()
        {

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Console.WriteLine($"{listOfPersons[i].FirstName} has the following gifts");

                foreach(ChristmasGifts gift in listOfPersons[i].ListOfGifts)
                {
                    Console.WriteLine(gift);
                }
            }

        }

    }


}

