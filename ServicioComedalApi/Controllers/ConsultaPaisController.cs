using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicioComedalApi.Domain.ServicioSOAP;

namespace ServicioComedalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaPaisController : ControllerBase
    {

        [HttpGet]
        [Route("ConsultarCaracteristicasPaises/{NombrePais}")]
        public async Task<string> ConsultarCaracteristicasPaises(string NombrePais)
        {
            WSCaracteristicasPais obj = new WSCaracteristicasPais();
            var test = await obj.GetCaracteristicasPaisAsync(NombrePais);
            return test;
        }
               
    }
}
