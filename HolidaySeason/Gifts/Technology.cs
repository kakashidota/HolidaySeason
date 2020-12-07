using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{
    class Technology : ChristmasGifts
    {

        private int batteries;
        private bool needsAssembly;

        public int Batteries { get => batteries; set => batteries = value; }
        public bool NeedsAssembly { get => needsAssembly; set => needsAssembly = value; }
    }
}
