namespace CompanyService.DesignPatterns.Creational;

/*
 Problem: When dealing with complex objects with many configuration options, constructors with numerous parameters become unwieldy and error-prone.

The Builder Pattern simplifies object creation by separating the construction process from the actual representation.

Solution: The Builder Pattern introduces a director class that orchestrates the construction of complex objects using a builder interface. The builder interface provides methods to set the object’s properties step by step, resulting in a more readable and maintainable way to create objects with various configurations.
 */


// Product class
class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
}

// Builder interface
interface IPizzaBuilder
{
    IPizzaBuilder SetDough(string dough);
    IPizzaBuilder SetSauce(string sauce);
    Pizza Build();
}

// Concrete builder
class PizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public IPizzaBuilder SetDough(string dough)
    {
        pizza.Dough = dough;
        return this;
    }

    public IPizzaBuilder SetSauce(string sauce)
    {
        pizza.Sauce = sauce;
        return this;
    }

    public Pizza Build()
    {
        return pizza;
    }
}

// Director (optional)
class PizzaDirector
{
    private readonly IPizzaBuilder pizzaBuilder;

    public PizzaDirector(IPizzaBuilder builder)
    {
        pizzaBuilder = builder;
    }

    public Pizza CreateVegetarianPizza()
    {
        return pizzaBuilder
            .SetDough("Whole Wheat")
            .SetSauce("Tomato")
            .Build();
    }

    public Pizza CreatePepperoniPizza()
    {
        return pizzaBuilder
            .SetDough("Thin Crust")
            .SetSauce("Spicy Tomato")
            .Build();
    }
}