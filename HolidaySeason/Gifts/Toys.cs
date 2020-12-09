using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{

    //TODO: Skapa upp 4 typer av toys, Crafting, Puzzle, Lego, Doll
    //TODO: Ge dessa passande koncept

    class Toys : ChristmasGifts
    {
        private int recomendedAge;

        public Toys(int recomendedAge, string name, int price, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.recomendedAge = recomendedAge;
        }


        //TODO: Override tostring metoden och skriv ut något generellt
    }
}
