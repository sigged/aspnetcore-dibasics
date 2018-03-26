using CoreCourse.DIBasics.Domain.CoffeeSystem;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Sugar : ISweetener
    {
        public Sugar()
        {
            Name = "Sugar";
        }

        public string Name { get; protected set; }
        
    }
}
