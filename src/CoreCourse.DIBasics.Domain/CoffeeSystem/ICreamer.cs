using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.DIBasics.Domain.CoffeeSystem
{
    public interface ICreamer
    {
        string Name { get; }
        double LactosePercent { get; }
        double AlcoholPercent { get; }
    }
}
