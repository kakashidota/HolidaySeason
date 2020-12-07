using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{
    class Beauty : ChristmasGifts
    {

        private string skinType;
        private string color;

        public string SkinType { get => skinType; set => skinType = value; }
        public string Color { get => color; set => color = value; }
    }
}
