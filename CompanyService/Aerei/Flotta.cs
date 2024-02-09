using System.Security.Principal;

namespace CompanyService;

public class Flotta
{
    public long IdFLotta { get; set; }
    public List<Aereo> Aerei { get; set; }

    public Flotta(long idFLotta, List<Aereo> aerei)
    {
        IdFLotta = idFLotta;
        Aerei = aerei;
    }

    public Aereo? GetAereoById(long idAereo)
    {
        foreach (var aereo in Aerei)
        {
            if (aereo.IdAereo == idAereo)
            {
                return aereo;
            }
        }

        return null;
    }
}
