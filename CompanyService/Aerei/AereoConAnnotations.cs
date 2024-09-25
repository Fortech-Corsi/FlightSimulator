
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyService;

public class AereoConAnnotations
{
    [Key]
    public long AereoId { get; set; }
    [Required]
    public string CodiceAereo { get; set; }
    [MaxLength(100)]
    public string Colore { get; set; }
    public long NumeroDiPosti { get; set; }

    [ForeignKey(nameof(Flotta))]
    public long FlottaId { get; set; }
    public virtual Flotta Flotta { get; set; }

    public AereoConAnnotations()
    {
    }

    protected AereoConAnnotations(long aereoId, string codiceAereo, string colore, long numeroDiPosti, long flottaId)
    {
        this.AereoId = aereoId;
        this.CodiceAereo = codiceAereo;
        this.Colore = colore;
        this.NumeroDiPosti = numeroDiPosti;
        this.FlottaId = flottaId;
    }

    public static AereoConAnnotations AereoConAnnotationsFactory(long aereoId, string codiceAereo, string colore, long numeroDiPosti, long flottaId)
    {
        return new AereoConAnnotations(aereoId, codiceAereo, colore, numeroDiPosti, flottaId);
    }

    public static AereoConAnnotations AereoConAnnotationsFactoryCreate(string codiceAereo, string colore, long numeroDiPosti, long flottaId)
    {
        return new AereoConAnnotations(0, codiceAereo, colore, numeroDiPosti, flottaId);
    }
}
