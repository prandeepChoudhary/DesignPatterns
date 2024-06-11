using System;
namespace DesignPattern
{

	public interface IPizza //Product
	{
		string Eat();
	}

    class VegPizza : IPizza // and this concrete implemation of pizza, it may be diff type
    {
        public string Eat()
        {
            return "Eating Veg Pizza";
        }
    }
    class NonVegPizza : IPizza // and this concrete implemation of pizza, it may be diff type
    {
        public string Eat()
        {
            return "Eating Non-Veg Pizza";
        }
    }



    public interface IPizzaChef //Factory
    {
        IPizza PreparePizza();
    }
    class VegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }
    }
    class NonVegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }
    }


    public class Waiter //Client -means final class
    {
        public IPizza GetPizza(string type)
        {
            IPizzaChef chef;
            switch(type)
            {
                case "Veg":
                    chef = new VegPizzaChef();
                    break;
                default:
                    chef = new NonVegPizzaChef();
                    break;
            }
            return chef.PreparePizza();
        }
    }
}

