namespace CompanyService;

public class CreateAereoRequest
{
    public string CodiceAereo { get; set; }
    public string Colore { get; set; }
    public long NumeroDiPosti { get; set; }
    
    public CreateAereoRequest(string codiceAereo, string colore, long numeroDiPosti)
    {        
        CodiceAereo = codiceAereo;
        Colore = colore;
        NumeroDiPosti = numeroDiPosti;
    }
}
