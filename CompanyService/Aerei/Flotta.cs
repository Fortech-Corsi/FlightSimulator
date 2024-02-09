using System.Security.Principal;

namespace CompanyService;

public class Flotta
{
    public List<Aereo> Aerei { get; set; }

    public Flotta(List<Aereo> aerei)
    {
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
