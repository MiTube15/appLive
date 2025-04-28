using APPLIVES.APPLICATION;
using Microsoft.AspNetCore.Mvc;

namespace APPLIVE.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class APPLIVE : Controller
    {
        private readonly  APPLIVE_APPLICATION aPPLIVE_;

        public  APPLIVE( APPLIVE_APPLICATION aPPLIVE_APPLICATION)
        {
            aPPLIVE_= aPPLIVE_APPLICATION;
        }

        [HttpGet]

        public ActionResult <IEnumerable<APPLIVES_APPLICATION_ENLACES>>GetAll()
        {
            return Ok(aPPLIVE_.GetAllStreams());
        }

        [HttpGet("{channelName}")]
        public ActionResult<APPLIVES_APPLICATION_ENLACES> GetByChannel(string channelName)
        {
            var stream = aPPLIVE_.GetStreamByChannel(channelName);
            if (stream == null)
                return NotFound(new { message = "Canal no encontrado" });

            return Ok(stream);
        }
    }
}
