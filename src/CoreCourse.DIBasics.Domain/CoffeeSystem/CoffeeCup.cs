using CoreCourse.DIBasics.Domain.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.DIBasics.Domain.CoffeeSystem
{
    public class CoffeeCup : ICoffeeCup
    {
        public CoffeeCup(ICreamer creamer, ISweetener sweetener)
        {
            Creamer = creamer;
            Sweetener = sweetener;
        }

        public ICreamer Creamer { get; set; }
        public ISweetener Sweetener { get; set; }
    }
}
