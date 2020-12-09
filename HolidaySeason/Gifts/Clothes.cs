using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{


    //Skapa upp 3 subklasser av clothes, Tshirt, byxor, Jacka
    class Clothes : ChristmasGifts
    {

        private string type;
        private string brand;
        private string size;

        public Clothes(string type, string brand, string size, int price, string name)
        {
            this.Name = name;
            this.Price = price;
            this.type = type;
            this.brand = brand;
            this.size = size;
        }

        public string Type { get => type; set => type = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Size { get => size; set => size = value; }

        
      
    }
}
