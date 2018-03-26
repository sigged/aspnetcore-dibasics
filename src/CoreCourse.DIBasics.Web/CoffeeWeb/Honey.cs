using CoreCourse.DIBasics.Domain.CoffeeSystem;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Honey : ISweetener
    {
        public Honey()
        {
            Name = "Honey";
        }

        public string Name { get; protected set; }
        
    }
}
