namespace CompanyService.DesignPatterns.Behavioral;

/*
 Problem: Establishing dependencies between objects that need to be notified of changes in another object’s state can lead to tight coupling.

The Observer Pattern solves this by defining a one-to-many relationship, where the subject notifies multiple observers of changes without knowing their specific types.

Solution: The Observer Pattern involves a subject (observable) that maintains a list of observers. When the subject’s state changes, it notifies all registered observers. Observers implement an interface defining an update method, enabling them to respond to changes in the subject’s state.
 */


// Example: Implementing a stock market observer
public interface IObserver
{
    void Update(string message);
}

public class Stock : IObserver
{
    private string symbol;
    private double price;

    public Stock(string symbol, double price)
    {
        this.symbol = symbol;
        this.price = price;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{symbol} - Price: {price} - {message}");
    }
}

public class StockMarket
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void UpdatePrices()
    {
        // Simulate price changes and notify observers
        foreach (var observer in observers)
        {
            observer.Update("Price increased by 0.5%");
        }
    }
}