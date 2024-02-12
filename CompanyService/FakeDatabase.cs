using CompanyService;

public static class FakeDatabase
{
    public static List<Flotta> Flotte { get; set; }
    public static long IdAereoKey { get; set; }

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

        IdAereoKey = 10;
    }

    public static Aereo? GetAereoDaIdAereo(long idAereo)
    {

        foreach (var flotta in Flotte)
        {
            foreach (var aereo in flotta.Aerei)
            {
                if (aereo.IdAereo == idAereo)
                {
                    return aereo;
                }
            }
        }

        return null;
    }

    public static Flotta? GetFlottaByIdFlotta(long idFlotta)
    {
        return Flotte.FirstOrDefault(x => x.IdFLotta == idFlotta);
    }

    public static Aereo AddAereoAFlotta(long idFlotta, string codiceAereo,
    string colore, long numeroPosti)
    {
        var aereoBl = Aereo.AereoFakeDBCreateFactory(IdAereoKey, codiceAereo,
     colore, numeroPosti);
        IdAereoKey++;

        foreach (var flotta in Flotte)
        {
            if (flotta.IdFLotta == idFlotta)
            {
                flotta.Aerei.Add(aereoBl);
                break;
            }
        }

        return aereoBl;
    }

    public static void DeleteAereoDaIdAereo(long idAereo)
    {
        Flotta flottaSelezionata = null;
        Aereo aereoSelezionato = null;

        foreach (var flotta in Flotte)
        {
            foreach (var aereo in flotta.Aerei)
            {
                if (aereo.IdAereo == idAereo)
                {
                    flottaSelezionata = flotta;
                    aereoSelezionato = aereo;
                    break;
                }
            }
        }

        flottaSelezionata.Aerei.Remove(aereoSelezionato);
    }
}