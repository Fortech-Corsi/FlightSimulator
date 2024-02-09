using System.Net;
using AirRouteAdministrator.API;
using Microsoft.AspNetCore.Mvc;

namespace TestProject;

public class AereoControllerTests{
   
    [Fact]  
    public async void GetAereo_RecuperoUnAereo_RitornoUnAereo(){
        
        // ARRANGE
        var _aereoController = new AereoController();
        long idAereo = 1;

        // ACT
        var result = await _aereoController.Get(idAereo) as OkObjectResult;

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
    }
}