using System.Security.Principal;

namespace CompanyService;

public class Flotta
{
    public long FlottaId { get; set; }
    public virtual ICollection<Aereo> Aerei { get; set; }

    public Flotta()
    {

    } 

    public Flotta(long idFLotta, List<Aereo> aerei)
    {
        FlottaId = idFLotta;
        Aerei = aerei;
    }

    public Aereo? GetAereoById(long idAereo)
    {
        foreach (var aereo in Aerei)
        {
            if (aereo.AereoId == idAereo)
            {
                return aereo;
            }
        }

        return null;
    }

}
