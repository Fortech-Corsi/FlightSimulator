namespace CompanyService.DesignPatterns.Creational;

/*
 Problem: Ensuring that a class has only one instance can be challenging, especially when multiple parts of the codebase need access to that instance.

The Singleton Pattern addresses this by restricting the instantiation of a class to a single instance and providing a global point of access to that instance.

Solution: The Singleton Pattern involves creating a private constructor to prevent direct instantiation and a static method or property to access the single instance. The first time the instance is requested, it’s created; subsequent requests return the existing instance, ensuring that there’s only one instance of the class.
 */


// Example: Creating a single configuration manager
public class ConfigurationManager
{
    private static ConfigurationManager _instance;

    private ConfigurationManager() { }

    public static ConfigurationManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigurationManager();
            }
            return _instance;
        }
    }

    public string GetSetting(string key)
    {
        // Retrieve setting from configuration file
        return "Value for " + key;
    }
}