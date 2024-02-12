using System.Net;
using AirRouteAdministrator.API;
using CompanyService;
using Microsoft.AspNetCore.Mvc;

namespace TestProject;

public class AereoControllerTests{
   
    [Fact]  
    public async void GetAereo_RecuperoUnAereo_RitornoUnAereo(){
        
        // ARRANGE
        var _aereoController = new AereoController();
        long idAereo = 1;

        // ACT
        var result = await _aereoController.Get(idAereo) as ObjectResult;

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
    }

    [Fact]  
    public async void GetAereo_RecuperoUnAereo_RitornoNotFound(){
        
        // ARRANGE
        var _aereoController = new AereoController();
        long idAereo = 10;

        // ACT
        var result = await _aereoController.Get(idAereo) as ObjectResult;

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
    }

    [Fact]  
    public async void PostAereo_CreoUnAereo_AereoCreato(){
        
        // ARRANGE
        var _aereoController = new AereoController();
        CreateAereoRequest createAereoRequest = new CreateAereoRequest(10000,
        "MONTI", "ASADADADA", 100);

        // ACT
        // POST
        var result = await _aereoController.Post(createAereoRequest) as ObjectResult;

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
    }

    [Fact]  
    public async void PostAereo_CreoUnAereo_AereoTrovatoEVerificato(){
        
        // ARRANGE
        var _aereoController = new AereoController();
        CreateAereoRequest createAereoRequest = new CreateAereoRequest(10000,
        "MONTI", "ASADADADA", 100);

        // ACT
        // POST
        var result = await _aereoController.Post(createAereoRequest) as ObjectResult;

        // ASSERT
        Assert.NotNull(result);
        Assert.NotNull(result.Value);
        Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        
        AereoApi a = (AereoApi)result.Value;
        var resultGet = await _aereoController.Get(a.IdAereo) as ObjectResult;
        Assert.NotNull(resultGet);
        Assert.NotNull(resultGet.Value);

        AereoApi b = (AereoApi)resultGet.Value;
        Assert.Equal(a.CodiceAereo, b.CodiceAereo);
        Assert.Equal(a.Colore, b.Colore);
        Assert.Equal(a.NumeroDiPosti, b.NumeroDiPosti);
        
    }
}