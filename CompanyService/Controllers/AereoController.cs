using System.Net;
using CompanyService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http.HttpResults;
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
        var aereo = FakeDatabase.GetAereoDaIdAereo(idAereo);
        if (aereo == null)
        {
            return NotFound();
        }

        // convertiamo nel modello del contratto
        var result = new AereoApi(aereo.IdAereo, aereo.CodiceAereo,
        aereo.Colore, aereo.NumeroDiPosti);

        return Ok(result);
    }


    [HttpPost()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoApi), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Post(CreateAereoRequest request)
    {
        // Verifichiamo l'esistenza della flotta
        var flotta = FakeDatabase.GetFlottaByIdFlotta(request.IdFLotta);
        if (flotta == null)
        {
            return BadRequest("No ho trovato la flotta");
        }

        // Inserimento nel database
        var aereoBl = FakeDatabase.AddAereoAFlotta(request.IdFLotta, request.CodiceAereo, request.Colore, request.NumeroDiPosti);

        // Converto il modello di bl in quello api
        var aereoApi = new AereoApi(aereoBl.IdAereo, aereoBl.CodiceAereo, aereoBl.Colore, aereoBl.NumeroDiPosti);

        // Restituisco il modello api
        return Ok(aereoApi);
    }

    [HttpDelete()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoApi), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Delete(long idAereo)
    {
         // Recupero le informazioni dal db     
        var aereo = FakeDatabase.GetAereoDaIdAereo(idAereo);
        if (aereo == null)
        {
            return NotFound();
        }
        FakeDatabase.DeleteAereoDaIdAereo(idAereo);
        return Ok();
    }

    [HttpPut()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoApi), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Put(UpdateAereoRequest request)
    {
         // Recupero le informazioni dal db     
        var aereo = FakeDatabase.GetAereoDaIdAereo(request.IdAereo);
        if (aereo == null)
        {
            return NotFound();
        }

        var aereoBl = FakeDatabase.UpdateAereoByIdAereo(request.IdAereo, request.CodiceAereo, request.Colore, request.NumeroDiPosti);

         // Converto il modello di bl in quello api
        var aereoApi = new AereoApi(aereoBl.IdAereo, aereoBl.CodiceAereo, aereoBl.Colore, aereoBl.NumeroDiPosti);

        // Restituisco il modello api
        return Ok(aereoApi);

    }
}
