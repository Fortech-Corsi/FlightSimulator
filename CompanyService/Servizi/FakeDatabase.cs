using CompanyService;

public class FakeDatabase 
{
    public static List<Flotta> Flotte { get; set; }
    public static long IdAereoKey { get; set; }
    public static long IdFlottaKey { get; set; }

    static FakeDatabase()
    {
        var aereo1 = new Aereo(1, 10000,  "ABCDEF1", "Rosso", 120);
        var aereo2 = new Aereo(2,  10000,"ABCDEF2", "Rosso", 120);
        var aereo3 = new Aereo(3,  10000,"ABCDEF3", "Rosso", 120);
        Flotta f1 = new Flotta(10000, [aereo1, aereo2, aereo3]);

        var aereo4 = new Aereo(4, 10001,"ABCDEF4", "Rosso", 120);
        var aereo5 = new Aereo(5, 10001,"ABCDEF5", "Rosso", 120);
        var aereo6 = new Aereo(6, 10001,"ABCDEF6", "Rosso", 120);
        Flotta f2 = new Flotta(10001, [aereo4, aereo5, aereo6]);

        var aereo7 = new Aereo(7,10002, "ABCDEF7", "Rosso", 120);
        var aereo8 = new Aereo(8, 10002,"ABCDEF8", "Rosso", 120);
        Flotta f3 = new Flotta(10002, [aereo7, aereo8]);

        Flotte = new List<Flotta>() { f1, f2, f3 };

        IdAereoKey = 10;
        IdFlottaKey = 10010;
    }

    public Task<Aereo?> GetAereoDaIdAereo(long idAereo)
    {
        foreach (var flotta in Flotte)
        {
            foreach (var aereo in flotta.Aerei)
            {
                if (aereo.AereoId == idAereo)
                {
                    return Task.FromResult<Aereo?>(aereo);
                }
            }
        }

        return Task.FromResult<Aereo?>(null);
    }

    public async Task<Flotta?> GetFlottaByIdFlotta(long idFlotta)
    {
        return Flotte.FirstOrDefault(x => x.FlottaId == idFlotta);
    }

    public async Task<Aereo> AddAereoAFlotta(long idFlotta, string codiceAereo,
    string colore, long numeroPosti)
    {
        var aereoBl = Aereo.AereoFakeDBCreateFactory(IdAereoKey,idFlotta, codiceAereo,
     colore, numeroPosti);
        IdAereoKey++;

        foreach (var flotta in Flotte)
        {
            if (flotta.FlottaId == idFlotta)
            {
                flotta.Aerei.Add(aereoBl);
                break;
            }
        }

        return aereoBl;
    }

    public async Task DeleteAereoDaIdAereo(long idAereo)
    {
        Flotta flottaSelezionata = null;
        Aereo aereoSelezionato = null;

        foreach (var flotta in Flotte)
        {
            foreach (var aereo in flotta.Aerei)
            {
                if (aereo.AereoId == idAereo)
                {
                    flottaSelezionata = flotta;
                    aereoSelezionato = aereo;
                    break;
                }
            }
        }

        flottaSelezionata.Aerei.Remove(aereoSelezionato);
    }

    public async Task<Aereo?> UpdateAereoByIdAereo(long idAereo, string codiceAereo, string colore, long numeroDiPosti)
    {
        var aereo = await GetAereoDaIdAereo(idAereo);
        if (aereo != null)
        {
            aereo.UpdateInformazioniAereo(codiceAereo, colore, numeroDiPosti);
        }

        return aereo;
    }

    public async Task<List<Flotta>> GetElencoFlotte()
    {
        return Flotte;
    }

    public async Task<Flotta> CreateFlotta()
    {
        var newFlotta = new Flotta(IdFlottaKey, new List<Aereo>());
        IdFlottaKey++;
        Flotte.Add(newFlotta);
        return newFlotta;
    }
}