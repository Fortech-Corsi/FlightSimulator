namespace CompanyService.DesignPatterns.Structural;

/*
 Problem: Separating an abstraction from its implementation is crucial in large software systems to promote flexibility and maintainability.

The Bridge Pattern achieves this separation by defining two separate hierarchies for abstraction and implementation, allowing them to evolve independently.

Solution: The Bridge Pattern involves creating an abstract class (abstraction) that contains a reference to an interface (implementation). The abstraction delegates the implementation details to the interface, enabling different implementations to be used interchangeably without affecting the abstraction.
 */


// Example: Implementing different shapes with various drawing methods
public interface IDrawAPI
{
    void DrawCircle(int radius);
}

public class RedCircle : IDrawAPI
{
    public void DrawCircle(int radius) => Console.WriteLine($"Drawing Red Circle of radius {radius}");
}

public class GreenCircle : IDrawAPI
{
    public void DrawCircle(int radius) => Console.WriteLine($"Drawing Green Circle of radius {radius}");
}

public abstract class Shape
{
    protected IDrawAPI drawAPI;

    protected Shape(IDrawAPI drawAPI)
    {
        this.drawAPI = drawAPI;
    }

    public abstract void Draw();
}

public class Circle : Shape
{
    private int radius;

    public Circle(int radius, IDrawAPI drawAPI) : base(drawAPI)
    {
        this.radius = radius;
    }

    public override void Draw() => drawAPI.DrawCircle(radius);
}