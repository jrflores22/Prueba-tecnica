using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication3.Business.Factory;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class EjemploController : ControllerBase
    {
        private readonly SqlConnection _sqlConnection;
        public EjemploController(IConfiguration configuration)
        {
            _sqlConnection = new SqlConnection(configuration.GetConnectionString("defaultConnection"));
        }

        [HttpPost("ejemplo")]
        public ActionResult<Models.ExampleResponse> PostEjemplo(Models.ExampleSNS request)
        {
            if (Request.Headers["MessageVisibility"] == "CUSTOMER")
            {
                //Instanciar por CUSTOMER, ALL, o AGENT 
            }

            var factory = new EjemploFactory(_sqlConnection);
            var ejemploService = factory.GetImplementation();
            var response = ejemploService.PostEjemploService(request);
            return Ok(response);
        }
    }
}
