﻿using CompanyService;

namespace TestProject;

public class FlottaTests
{
    [Fact]
    public void VerificareCheDatoUnidRitorniUnsoloAereo(){
        
        // ARRANGE
        var aereo1 = new Aereo(1, "ABCDEF1");
        var aereo2 = new Aereo(2, "ABCDEF2");
        var aereo3 = new Aereo(3, "ABCDEF3");

        List<Aereo> lista = new List<Aereo>();
        lista.Add(aereo1);
        lista.Add(aereo2);
        lista.Add(aereo3);

        Flotta f = new Flotta(lista);

        // ACT
        var aereo = f.GetAereoById(aereo1.IdAereo);

        // ASSERT
        Assert.NotNull(aereo);         
        Assert.Equal(aereo1.IdAereo, aereo.IdAereo);
        Assert.Equal(aereo1.CodiceAereo, aereo.CodiceAereo);       
    }

    [Fact]
    public void VerificareCheDatoUnidRitorniNullSelAereoNonEsiste(){
        
          
        // ARRANGE
        var aereo1 = new Aereo(1, "ABCDEF1");
        var aereo2 = new Aereo(2, "ABCDEF2");
        var aereo3 = new Aereo(3, "ABCDEF3");

        List<Aereo> lista = new List<Aereo>();
        lista.Add(aereo1);
        lista.Add(aereo2);
        lista.Add(aereo3);

        Flotta f = new Flotta(lista);

        int idAereoNonEsistente = 10;

        // ACT
        var aereo = f.GetAereoById(idAereoNonEsistente);

        // ASSERT
        Assert.Null(aereo);         
    }
}
