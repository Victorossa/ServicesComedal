using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComedalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static ServicioVictor.CountryInfoServiceSoapTypeClient;

namespace ComedalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //CountryInfoServiceSoapTypeClient obj = new CountryInfoServiceSoapTypeClient(EndpointConfiguration.CountryInfoServiceSoap);

            //ListOfCountryNamesByCodeRequest ob = new ListOfCountryNamesByCodeRequest();

            //var respuesta = obj.ListOfCountryNamesByCodeAsync(ob);

            return new string[] { "value1", "value2" };

        }

        public async Task<string> GetInformacionPaisAsync(string NombrePais)
        {
            try
            {
                #region Declarar Variables e inicializacion

                string ISOPais = string.Empty;
                string ISOMoneda = string.Empty;
                string NombreMoneda = string.Empty;

                ServicioVictor.FullCountryInfoResponse oFullCountryInfoResponse;
                ServicioVictor.tLanguage[] oLstIdiomas;
                ServicioVictor.CountryCurrencyResponse oCountryCurrencyResponse;

                InfoPaisClass oInfoPaisClass = new InfoPaisClass();

                EndpointConfiguration oEC = new EndpointConfiguration();
                ServicioVictor.CountryInfoServiceSoapTypeClient services;


                oEC = EndpointConfiguration.CountryInfoServiceSoap;
                services = new ServicioVictor.CountryInfoServiceSoapTypeClient(oEC);

                //Variable Encargada de guardar el Resultado del consumo del servicios
                ServicioVictor.CountryISOCodeResponse oCountryISOCodeResponse;


                #endregion

                //Se consume Operation CountryISOCodeAsync para obtener el codio ISO del pais
                oCountryISOCodeResponse = await services.CountryISOCodeAsync(NombrePais);
                //Se almacena el codigo ISO del pais
                ISOPais = oCountryISOCodeResponse.Body.CountryISOCodeResult != "No country found by that name" ? oCountryISOCodeResponse.Body.CountryISOCodeResult : string.Empty;

                //Se valida si se encontro el pais
                if (ISOPais != string.Empty)
                {
                    //Se consume Operation FullCountryInfoAsync para obtener toda la informacion del Pais 
                    oFullCountryInfoResponse = await services.FullCountryInfoAsync(ISOPais);

                    //Se valida que no hubiesen problemas consultando la informacion
                    if (oFullCountryInfoResponse != null)
                    {
                        //Se llena la lista de Idiomas del Operation FullCountryInfoAsync
                        oLstIdiomas = oFullCountryInfoResponse.Body.FullCountryInfoResult.Languages;
                        //Se llena el ISO de la moneda del Operation FullCountryInfoAsync
                        ISOMoneda = oFullCountryInfoResponse.Body.FullCountryInfoResult.sCurrencyISOCode;


                        //Se consume el Operation CountryCurrencyAsync para obtener el nombre de la moneda
                        oCountryCurrencyResponse = await services.CountryCurrencyAsync(ISOPais);
                        //Se llena el nombre de la moneta
                        NombreMoneda = oCountryCurrencyResponse.Body.CountryCurrencyResult.sName;

                        ///Se llena la informacion del pais y se devuelve en JSON
                        oInfoPaisClass.NombrePais = pais;
                        oInfoPaisClass.ISOPais = ISOPais;
                        oInfoPaisClass.ISOMoneda = ISOMoneda;
                        oInfoPaisClass.ListaIdiomas = oLstIdiomas;
                        oInfoPaisClass.NombreMoneda = NombreMoneda;

                        return JsonConvert.SerializeObject(oInfoPaisClass);


                    }
                    else
                    {
                        string respuesta = @"Respuesta: Ocurrió un error consultando la información del país. Contacte al administrador del sistema.";
                        return respuesta;
                    }
                }
                else
                {
                    string respuesta = @"Respuesta: No se encontró información del País. Intente con el nombre en inglés o con la primera letra en mayúsculas.";
                    return respuesta;
                }

            }
            catch (Exception Ex)
            {
                //_utilities.SaveLog(this, Ex);
                string respuesta = @"Respuesta: Ocurrió un error inesperado. Contacte al administrador del sistema.";
                return respuesta;
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
