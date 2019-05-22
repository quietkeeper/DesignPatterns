using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior
{
    public class People
    {

        public IEat EatBehavior;
        public IMove MoveBehavior;
    }

    public interface IEat
    {
        public string Eat();
    }
    public interface IMove
    {
        public string Move();
    }

    public class NormalEat : IEat
    {
        public string Eat()
        {
            return "Eat different food";
        }
    }

    public class VegetarianEat : IEat
    {
        public string Eat()
        {
            return "Eat vegetable only";
        }
    }

}
