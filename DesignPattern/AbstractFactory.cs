namespace DesignPattern;

public interface IBurger //IProduct B
{
    string Eat();
}

class VegBurger : IBurger // and this ConcreteProduct 1B
{
    public string Eat()
    {
        return "Eating Veg Burger";
    }
}
class NonVegBurger : IBurger // and this ConcreteProduct 2B
{
    public string Eat()
    {
        return "Eating Non-Veg Burger";
    }
}


interface IChef //Factory
{
    IPizza PreparePizza();
    IBurger PrepareBurger();
}

class VegChef : IChef
{
    public IPizza PreparePizza()
    {
        return new VegPizza();
    }
    
    public IBurger PrepareBurger()
    {
        return new VegBurger();
    }
}

class NonVegChef : IChef
{
    public IPizza PreparePizza()
    {
        return new NonVegPizza();
    }
    
    public IBurger PrepareBurger()
    {
        return new NonVegBurger();
    }
}

class CallWaiter //client 
{
    private IChef foodFactory;
    public CallWaiter(string preference)
    {
        if(preference == "Veg")
        {
            foodFactory = new VegChef();
        }
        else
        {
            foodFactory = new NonVegChef();
        }
    }

    public IPizza GetPizza()
    {
        return foodFactory.PreparePizza();
    }

    public IBurger GetBurger()
    {
        return foodFactory.PrepareBurger();
    }
}