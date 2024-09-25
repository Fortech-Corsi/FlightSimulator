namespace CompanyService.DesignPatterns.Structural;

/*
 Decorator Pattern
Problem: Adding new responsibilities to objects dynamically without modifying their class hierarchy can be challenging.

The Decorator Pattern addresses this by attaching additional behaviors to objects without altering their structure.

Solution: The Decorator Pattern introduces decorator classes that wrap the core object (component) and provide additional functionality. These decorators implement the same interface as the core object, allowing them to be stacked and combined to extend the object’s behavior while keeping the core object intact.
 */


// Example: Adding toppings to a pizza
public abstract class Pizza
{
    public abstract string GetDescription();
    public abstract double GetCost();
}

public class MargheritaPizza : Pizza
{
    public override string GetDescription() => "Margherita Pizza";
    public override double GetCost() => 6.99;
}

public abstract class PizzaDecorator : Pizza
{
    protected Pizza pizza;

    public PizzaDecorator(Pizza pizza)
    {
        this.pizza = pizza;
    }

    public override string GetDescription() => pizza.GetDescription();
    public override double GetCost() => pizza.GetCost();
}

public class ExtraCheese : PizzaDecorator
{
    public ExtraCheese(Pizza pizza) : base(pizza) { }

    public override string GetDescription() => $"{pizza.GetDescription()}, Extra Cheese";
    public override double GetCost() => pizza.GetCost() + 1.50;
}