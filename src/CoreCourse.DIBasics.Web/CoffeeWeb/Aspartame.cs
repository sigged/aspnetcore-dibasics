using CoreCourse.DIBasics.Domain.CoffeeSystem;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Aspartame : ISweetener
    {
        public Aspartame()
        {
            Name = "Aspartame";
        }

        public string Name { get; protected set; }
        
    }
}
