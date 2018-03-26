using CoreCourse.DIBasics.Domain.CoffeeSystem;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Milk : ICreamer
    {
        public Milk()
        {
            Name = "Milk";
            LactosePercent = 0.048;
            AlcoholPercent = 0;
        }

        public string Name { get; protected set; }
        public double LactosePercent { get; protected set; }
        public double AlcoholPercent { get; protected set; }
    }
}
