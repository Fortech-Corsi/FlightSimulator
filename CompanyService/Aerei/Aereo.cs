
namespace CompanyService;

public class Aereo
{
    public long IdAereo { get; set; }
    public string CodiceAereo { get; set; }
    public string Colore { get; set; }
    public long NumeroDiPosti { get; set; }    

    
    public Aereo(long idAereo, string codiceAereo, string colore, long numeroDiPosti)
    {
        IdAereo = idAereo;
        CodiceAereo = codiceAereo;
        Colore = colore;
        NumeroDiPosti = numeroDiPosti;
    }

    public static Aereo AereoCreateFactory(string codiceAereo, string colore, long numeroDiPosti){
        return new Aereo(0, codiceAereo, colore, numeroDiPosti);
    }

    public static Aereo AereoFakeDBCreateFactory(long idAereo, string codiceAereo, string colore, long numeroDiPosti){
        return new Aereo(idAereo, codiceAereo, colore, numeroDiPosti);
    }

    public void UpdateInformazioniAereo(string codiceAereo, string colore, long numeroDiPosti)
    {
        this.CodiceAereo = codiceAereo;
        this.Colore = colore;
        this.NumeroDiPosti = numeroDiPosti;
    }

}
