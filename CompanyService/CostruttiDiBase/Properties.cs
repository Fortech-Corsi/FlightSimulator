namespace CompanyService.CostruttiDiBase;

/*
 The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

- declare fields/variables as private
- provide public get and set methods, through properties, to access and update the value of a private field
 */

class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class ProgramProperties
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}


/*
 C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.
 */

class PersonAutomatic
{
    public string Name  // property
    { get; set; }
}

class ProgramPropertiesAutomatic
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}