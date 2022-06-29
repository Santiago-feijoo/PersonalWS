using Microsoft.AspNetCore.Mvc;
using PersonalWS.Models;

namespace PersonalWS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("GetDocumentTypes")]
        public DocumentTypes getDocumentTypes()
        {
            var documentType = new DocumentTypes();
            documentType.documentTypeId = 1;
            documentType.acronym = "CC";
            documentType.description = "Cedula de ciudadanía";

            return documentType;
        }

    }
}
