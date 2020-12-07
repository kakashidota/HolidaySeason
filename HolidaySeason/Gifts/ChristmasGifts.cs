using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{
    class ChristmasGifts
    {

        private string name;
        private int price;
        private string category;
        private string targetGroup;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
        public string TargetGroup { get => targetGroup; set => targetGroup = value; }

        public virtual void Description(int a, int b)
        {
            Console.WriteLine("This is a gift");
        }


        public override string ToString()
        {
            return $"{name} costs {price}kr.";
        }
    }
}
