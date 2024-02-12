using CompanyService;

namespace TestProject;

public class AereoTests
{
    [Fact]
    public void VerificaInizializzazioneId()
    {
        // ARRANGE
        int idAreeo = 1;
        string codiceAereo = "ABCDEF";
        string colore = "Rosso";
        long numeroDiPosti = 120;

        // ACT
        var aereo = new Aereo(idAreeo, codiceAereo, colore, numeroDiPosti );

        // ASSERT
        Assert.Equal(idAreeo, aereo.IdAereo);
        Assert.Equal(codiceAereo, aereo.CodiceAereo);
    }
}
