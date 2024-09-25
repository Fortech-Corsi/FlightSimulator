namespace CompanyService.DesignPatterns.Behavioral;

/*
 Problem: Encapsulating requests as objects allows for flexibility in command handling, such as queuing, logging, or undoing operations.

The Command Pattern achieves this by encapsulating a request as a command object, separating the sender from the receiver.

Solution: The Command Pattern defines command objects that encapsulate specific actions and parameters. These commands implement a common interface with an execute method. An invoker class invokes the command, which can be easily extended or swapped without altering the sender-receiver relationship.
 */


// Example: Implementing a remote control with different commands
public interface ICommand
{
    void Execute();
}

public class Light
{
    public void TurnOn() => Console.WriteLine("Light is ON");
    public void TurnOff() => Console.WriteLine("Light is OFF");
}

public class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute() => light.TurnOn();
}

public class LightOffCommand : ICommand
{
    private Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute() => light.TurnOff();
}