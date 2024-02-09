namespace CompanyService;

public class Aereo
{
    public int IdAereo { get; set; }
    public string CodiceAereo { get; set; }
    public string Colore { get; set; }
    public long NumeroDiPosti { get; set; }    
    public string CostoAcquistoAereo { get; set; }
    
    public Aereo(int idAereo, string codiceAereo, string colore, long numeroDiPosti, string costoAcquistoAereo)
    {
        IdAereo = idAereo;
        CodiceAereo = codiceAereo;
        Colore = colore;
        NumeroDiPosti = numeroDiPosti;
        CostoAcquistoAereo = costoAcquistoAereo;
    }

    public static Aereo AereoCreateFactory(string codiceAereo, string colore, long numeroDiPosti){
        return new Aereo(0, codiceAereo, colore, numeroDiPosti, string.Empty);
    }
}
