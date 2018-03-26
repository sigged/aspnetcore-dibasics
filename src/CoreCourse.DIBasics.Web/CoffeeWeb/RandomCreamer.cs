using CoreCourse.DIBasics.Domain.CoffeeSystem;
using System;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class RandomCreamer : ICreamer
    {
        private ICreamer _chosenCreamer;
        private static Random _random;

        public RandomCreamer(Random random)
        {
            _random = random;
            _chosenCreamer = PickRandomCreamer();
        }

        public string Name => _chosenCreamer.Name;

        public double LactosePercent => _chosenCreamer.LactosePercent;

        public double AlcoholPercent => _chosenCreamer.AlcoholPercent;

        private ICreamer PickRandomCreamer()
        {
            //pick random sweetener
            switch (_random.Next(0, 3))
            {
                case 1:
                    return new Cream();
                case 2:
                    return new Whiskey();
                default:
                    return new Milk();
            }
        }
    }


}
