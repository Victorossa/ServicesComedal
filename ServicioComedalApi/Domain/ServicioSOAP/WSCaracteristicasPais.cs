using Newtonsoft.Json;
using ServicioComedalApi.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ServicioComedal.CountryInfoServiceSoapTypeClient;

namespace ServicioComedalApi.Domain.ServicioSOAP
{
    public class WSCaracteristicasPais
    {
        public async Task<string> GetCaracteristicasPaisAsync(string NombrePais)
        {
            try
            {
                //Definicion de variables segun lo solicitado
                //Codigo ISO, para obtener los datos en general del pais
                string ISOPais = string.Empty;
                //ISO Moneda para con este buscar la moneda del pais
                string ISOMoneda = string.Empty;
                //Para asignar el nombre una vez obtenido
                string NombreMoneda = string.Empty;

                //Creacion de variables desde la referencia del servicio
                //Toda la informacion de los servicios
                ServicioComedal.FullCountryInfoResponse oFullCountryInfoResponse;
                //Array de lista de idiomas
                ServicioComedal.tLanguage[] oLstIdiomas;
                //Informacion sobre las monedas
                ServicioComedal.CountryCurrencyResponse oCountryCurrencyResponse;
                //Instancia de DTO que contiene la estructura de todo lo que se necesita entregar
                InfoPaisClass oInfoPaisClass = new InfoPaisClass();

                EndpointConfiguration oEC = new EndpointConfiguration();

                ServicioComedal.CountryInfoServiceSoapTypeClient services;

                // se define el enpoint 
                oEC = EndpointConfiguration.CountryInfoServiceSoap;
                services = new ServicioComedal.CountryInfoServiceSoapTypeClient(oEC);

                //Variable Encargada de guardar el Resultado del consumo del servicios
                ServicioComedal.CountryISOCodeResponse oCountryISOCodeResponse;


                
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
                        oInfoPaisClass.Estado = true;
                        oInfoPaisClass.Observacion = "OK";
                        oInfoPaisClass.NombrePais = NombrePais;
                        oInfoPaisClass.ISOPais = ISOPais;
                        oInfoPaisClass.ISOMoneda = ISOMoneda;
                        oInfoPaisClass.ListaIdiomas = oLstIdiomas;
                        oInfoPaisClass.NombreMoneda = NombreMoneda;

                        return JsonConvert.SerializeObject(oInfoPaisClass);

                    }
                    else
                    {
                        oInfoPaisClass.Estado = false;
                        oInfoPaisClass.Observacion = "No se encontraron Paises";
                        string respuesta = @"Respuesta: Ocurrió un error consultando la información del país. Contacte al administrador del sistema.";
                        return respuesta;
                    }
                }
                else
                {
                    oInfoPaisClass.Estado = false;
                    oInfoPaisClass.Observacion = "No se encontraron Paises";
                    string respuesta = @"Respuesta: No se encontró información del País. Intente con el nombre en inglés o con la primera letra en mayúsculas.";
                    return respuesta;
                }

            }
            catch (Exception Ex)
            {
                string respuesta = @"Respuesta: Ocurrió un error inesperado. Contacte al administrador del sistema.";
                return respuesta;
            }


        }
    }
}
