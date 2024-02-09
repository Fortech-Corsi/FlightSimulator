using System.Net;
using CompanyService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace AirRouteAdministrator.API;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/aereo")]
public class AereoController : ControllerBase
{
    public AereoController()
    {
    }

    [HttpGet()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoApi), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get(long idAereo)
    {
        // Recupero le informazioni dal db     
       

        var result = new AereoApi(1, "Codice 1", "Bianco", 10);
        return Ok(result);
    }


    [HttpPost()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoApi), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Post(CreateAereoRequest request)
    {
        // Creo il modello di bl dell'aereo a partire dalla request
        var aereoBl = Aereo.AereoCreateFactory(request.CodiceAereo, request.Colore, request.NumeroDiPosti);

        // Converto il modello di bl in quello api
        var aereoApi = new AereoApi(aereoBl.IdAereo, aereoBl.CodiceAereo, aereoBl.Colore, aereoBl.NumeroDiPosti);

        // Restituisco il modello api
        return Ok(aereoApi);
    }
}
