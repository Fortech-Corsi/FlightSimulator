using CompanyService;

public static class FakeDatabase
{
    public static Flotta Flotta1 { get; set; }

    static FakeDatabase()
    {
        var aereo1 = new Aereo(1, "ABCDEF1", "Rosso", 120);
        var aereo2 = new Aereo(2, "ABCDEF2", "Rosso", 120);
        var aereo3 = new Aereo(3, "ABCDEF3", "Rosso", 120);
        List<Aereo> lista = [aereo1, aereo2, aereo3];
        Flotta f = new Flotta(lista);
        Flotta1 = f;
    }
}