using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{

    //TODO: skapa upp två Subklasser av klassen Beauty. Kalla dessa Lipstick & Foundation
    class Beauty : ChristmasGifts
    {

        private string skinType;
        private string color;

        public Beauty(string skinType, string color, int price, string name)
        {
            this.Name = name;
            this.Price = price;
            this.skinType = skinType;
            this.color = color;
        }

        public string SkinType { get => skinType; set => skinType = value; }
        public string Color { get => color; set => color = value; }

    }
}
