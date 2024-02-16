
namespace CompanyService;

public class Aereo
{
    public long AereoId { get; set; }
    public string CodiceAereo { get; set; }
    public string Colore { get; set; }
    public long NumeroDiPosti { get; set; }    

    public long FlottaId { get; set; }

   
    
    
    public Aereo(long flottaId, string codiceAereo, string? colore, long numeroDiPosti)
    {
        FlottaId = flottaId;
        CodiceAereo = codiceAereo;
        Colore = colore;
        NumeroDiPosti = numeroDiPosti;
    }

    public Aereo(long aereoId, long flottaId, string codiceAereo, string colore, long numeroDiPosti)
    {
        AereoId = aereoId;
        FlottaId = flottaId;
        CodiceAereo = codiceAereo;
        Colore = colore;
        NumeroDiPosti = numeroDiPosti;
    }
  
    public static Aereo AereoFakeDBCreateFactory(long idAereo, long flottaId,  string codiceAereo, string colore, long numeroDiPosti){
        return new Aereo(idAereo,flottaId,  codiceAereo, colore, numeroDiPosti);
    }

    public void UpdateInformazioniAereo(string codiceAereo, string colore, long numeroDiPosti)
    {
        this.CodiceAereo = codiceAereo;
        this.Colore = colore;
        this.NumeroDiPosti = numeroDiPosti;
    }

}
