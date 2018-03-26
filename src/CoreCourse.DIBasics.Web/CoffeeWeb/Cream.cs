using CoreCourse.DIBasics.Domain.CoffeeSystem;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Cream : ICreamer
    {
        public Cream()
        {
            Name = "Cream";
            LactosePercent = 0;
            AlcoholPercent = 0;
        }

        public string Name { get; protected set; }
        public double LactosePercent { get; protected set; }
        public double AlcoholPercent { get; protected set; }
    }
}
