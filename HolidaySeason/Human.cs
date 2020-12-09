using HolidaySeason.Gifts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason
{

    //TODO: Skapa upp 3 humans, Familj, släkt, Vän
    //TODO: Ge dessa passande fält
    class Human
    {

        private string firstName;
        private string lastName;
        private int age;
        private bool giftBack;
        private string relation;
        private List<ChristmasGifts> listOfGifts = new List<ChristmasGifts>();


        public Human(string firstName, string lastName, int age, bool giftBack, string relation)
        {
         
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.giftBack = giftBack;
            this.relation = relation;

        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public bool GiftBack { get => giftBack; set => giftBack = value; }
        public string Relation { get => relation; set => relation = value; }
        public List<ChristmasGifts> ListOfGifts { get => listOfGifts; set => listOfGifts = value; }


        //Modifera denna to string så att den inte är så beskrivande.
        public override string ToString()
        {
            return $"{firstName} {lastName} is {age}. Possiblity of gift back: {giftBack}. Current relation with this human {relation}";
        }
    }
}
