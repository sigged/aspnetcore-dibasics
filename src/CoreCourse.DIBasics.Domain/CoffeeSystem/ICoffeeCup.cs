namespace CoreCourse.DIBasics.Domain.CoffeeSystem
{
    public interface ICoffeeCup
    {
        ICreamer Creamer { get; }
        ISweetener Sweetener { get; }
    }
}
