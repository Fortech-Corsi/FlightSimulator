namespace CompanyService;

public interface IDatabaseService
{
    Aereo? GetAereoDaIdAereo(long idAereo);


    Flotta? GetFlottaByIdFlotta(long idFlotta);

    Aereo AddAereoAFlotta(long idFlotta, string codiceAereo,
    string colore, long numeroPosti);

    void DeleteAereoDaIdAereo(long idAereo);


    Aereo? UpdateAereoByIdAereo(long idAereo, string codiceAereo, string colore, long numeroDiPosti);


    List<Flotta> GetElencoFlotte();


    Flotta CreateFlotta();

}
