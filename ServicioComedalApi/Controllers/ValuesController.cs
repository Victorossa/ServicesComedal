using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicioComedalApi.Domain.DTO;
using ServicioComedalApi.Domain.Entity;
using ServicioComedalApi.Domain.ServicioREST;
using ServicioComedalApi.Domain.ServicioSOAP;

namespace ServicioComedalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Tipo de peticion recibida
        [HttpGet]
        //Con decorador de ruta para el metodo
        [Route("ConsultarEntidadesFinancieras/{Municipio}")]
        public async Task<ActionResult<RootObject>> ConsultarEntidadesFinancieras(string Municipio)
        {

            //Instanciamos la clase 
            WSInstitucionesFinancierasxMunicipio obj = new WSInstitucionesFinancierasxMunicipio();
            var test = await obj.GetEntFinMunicipioAsync(Municipio);
            return test;

        }
    }
}
