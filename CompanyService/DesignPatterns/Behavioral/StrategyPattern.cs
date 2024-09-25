namespace CompanyService.DesignPatterns.Behavioral;

/*
 Problem: Switching between different algorithms or behaviors at runtime can be challenging without introducing conditional statements.

The Strategy Pattern provides a solution by defining a family of interchangeable algorithms and making them easy to switch.

Solution: The Strategy Pattern involves defining a set of algorithms as separate classes, each implementing a common interface. The context class holds a reference to a strategy object and delegates the algorithm’s execution to it. This allows you to change strategies at runtime, promoting flexibility and maintainability.
 */


// Example: Sorting a list using different sorting algorithms
public interface ISortStrategy
{
    void Sort(List<int> list);
}

public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Sorting using Bubble Sort");
        // Implement Bubble Sort algorithm
    }
}

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> list)
    {
        Console.WriteLine("Sorting using Quick Sort");
        // Implement Quick Sort algorithm
    }
}

public class SortContext
{
    private ISortStrategy strategy;

    public SortContext(ISortStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SortList(List<int> list)
    {
        strategy.Sort(list);
    }
}