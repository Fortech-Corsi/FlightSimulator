using System.Net;
using CompanyService;
using Microsoft.AspNetCore.Mvc;

namespace AirRouteAdministrator.API;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/flight")]
public class FlightController : ControllerBase
{
    public FlightController()
    {
    }

    [HttpGet()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(List<AereoApi>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetListOfDigits()
    {
       var result = new List<AereoApi> {
            new AereoApi("Codice 1", "Bianco", 10),
            new AereoApi("Codice 2", "Nero", 20),
            new AereoApi("Codice 3", "Oro", 30),
            new AereoApi("Codice 4", "Argento", 10),
       };

        return Ok(result);         
        // return NotFound(flightId);       
    }   


    [HttpPost()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoApi), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> CreaVolo(CreateAereoRequest request)
    {
        // Creo il modello di bl dell'aereo a partire dalla request
        var aereoBl = Aereo.AereoCreateFactory(request.CodiceAereo, request.Colore, request.NumeroDiPosti);

        // Converto il modello di bl in quello api
        var aereoApi = new AereoApi(aereoBl.CodiceAereo, aereoBl.Colore, aereoBl.NumeroDiPosti);

        // Restituisco il modello api
        return Ok(aereoApi);         
        // return NotFound(flightId);       
    } 
}
