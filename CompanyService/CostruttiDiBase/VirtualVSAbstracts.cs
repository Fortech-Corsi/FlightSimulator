namespace CompanyService.CostruttiDiBase;

/*
 In C#, virtual methods can be overridden in derived classes, while abstract methods must be overridden in derived classes.
 */



/*
 An abstract class is a special type of class that cannot be instantiated directly. Instead, it serves as a blueprint for other classes. An abstract class may contain abstract methods, which are methods declared in the abstract class but must be implemented in concrete-derived classes.
 */
public abstract class Vehicle
{
    // abstract method to be implemented in non abstract child class
    public abstract void DisplayInfo();
}


/*
 Virtual methods are methods in a base class that have a default implementation but can be overridden in derived classes. The virtual keyword is used to declare a method as virtual. Derived classes use the override keyword to provide a specific implementation of the method, which helps to understand how a child class can override virtual method of its parent.
 */
// non abstract class
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Some generic animal sound");
    }
}


/*
 A class can have both abstract and virtual methods. Abstract methods do not have an implementation and must be overridden in derived classes, whereas virtual methods have a default implementation that derived classes can override optionally.
 */
public abstract class Vehicle2
{
    // Abstract method
    public abstract void DisplayInfo();
    // Virtual method
    public virtual void StartEngine()
    {
        Console.WriteLine("Engine started with default configuration.");
    }
}