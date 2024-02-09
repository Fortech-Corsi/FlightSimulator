namespace CompanyService;

public class AereoApi
{
    public string CodiceAereo { get; set; }
    public string Colore { get; set; }
    public long NumeroDiPosti { get; set; }
    
    public AereoApi(string codiceAereo, string colore, long numeroDiPosti)
    {
        CodiceAereo = codiceAereo;
         Colore = colore;
        NumeroDiPosti = numeroDiPosti;
    }
}
