using CompanyService;

public static class FakeDatabase
{
    public static List<Flotta> Flotte { get; set; }

    static FakeDatabase()
    {
        var aereo1 = new Aereo(1, "ABCDEF1", "Rosso", 120);
        var aereo2 = new Aereo(2, "ABCDEF2", "Rosso", 120);
        var aereo3 = new Aereo(3, "ABCDEF3", "Rosso", 120);
        Flotta f1 = new Flotta(10000, [aereo1, aereo2, aereo3]);

        var aereo4 = new Aereo(4, "ABCDEF4", "Rosso", 120);
        var aereo5 = new Aereo(5, "ABCDEF5", "Rosso", 120);
        var aereo6 = new Aereo(6, "ABCDEF6", "Rosso", 120);
        Flotta f2 = new Flotta(10001, [aereo4, aereo5, aereo6]);

        var aereo7 = new Aereo(7, "ABCDEF7", "Rosso", 120);
        var aereo8 = new Aereo(8, "ABCDEF8", "Rosso", 120);
        Flotta f3 = new Flotta(10002, [aereo7, aereo8]);

        Flotte = new List<Flotta>() { f1, f2, f3 };
    }
}