namespace CompanyService.CostruttiDiBase;

/*
 Generic means the general form, not specific. In C#, generic means not specific to a particular data type.

C# allows you to define generic classes, interfaces, abstract classes, fields, methods, static methods, properties, events, delegates, and operators using the type parameter and without the specific data type. A type parameter is a placeholder for a particular type specified when creating an instance of the generic type.

A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.
 */

class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}

class ProgramGenerici
{
    public static void Main(string[] args)
    {
        KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
        kvp1.Key = 100;
        kvp1.Value = "Hundred";

        KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
        kvp2.Key = "IT";
        kvp2.Value = "Information Technology";

        /*
        The List<T> class in C# is a generic collection that can store a list of items of any type, as shown in the following code:
        */
        List<int> integerList = new List<int>();
        integerList.Add(1);
        integerList.Add(2);

        List<string> stringList = new List<string>();
        stringList.Add("Apple");
        stringList.Add("Banana");
    }
}