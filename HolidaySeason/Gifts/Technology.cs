using System;
using System.Collections.Generic;
using System.Text;

namespace HolidaySeason.Gifts
{

    
    class Technology : ChristmasGifts
    {
        //TODO: Lägg till fler fält som ger en bättre beskrvning av produkten
        private int batteries;
        private bool needsAssembly;



        public Technology(int batteries, bool needsAssembly, string name, int price, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.batteries = batteries;
            this.needsAssembly = needsAssembly;
        }

        //TODO: Om produkten har batterirer, skriv ut något passande 

        public int Batteries { get => batteries; set => batteries = value; }
        public bool NeedsAssembly { get => needsAssembly; set => needsAssembly = value; }
    }
}
