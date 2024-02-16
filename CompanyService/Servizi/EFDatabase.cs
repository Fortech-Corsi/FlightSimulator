
namespace CompanyService;

public class EFDatabase : IDatabaseService
{
    public Task<Aereo> AddAereoAFlotta(long idFlotta, string codiceAereo, string colore, long numeroPosti)
    {
        throw new NotImplementedException();
    }

    public Task<Flotta> CreateFlotta()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAereoDaIdAereo(long idAereo)
    {
        throw new NotImplementedException();
    }

    public Task<Aereo?> GetAereoDaIdAereo(long idAereo)
    {
        throw new NotImplementedException();
    }

    public Task<List<Flotta>> GetElencoFlotte()
    {
        throw new NotImplementedException();
    }

    public Task<Flotta?> GetFlottaByIdFlotta(long idFlotta)
    {
        throw new NotImplementedException();
    }

    public Task<Aereo?> UpdateAereoByIdAereo(long idAereo, string codiceAereo, string colore, long numeroDiPosti)
    {
        throw new NotImplementedException();
    }
}
