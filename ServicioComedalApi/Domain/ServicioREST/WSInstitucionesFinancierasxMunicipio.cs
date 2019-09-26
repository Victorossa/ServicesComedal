using Newtonsoft.Json;
using ServicioComedalApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace ServicioComedalApi.Domain.ServicioREST
{
    public class WSInstitucionesFinancierasxMunicipio
    {
        //Declaracion de Variables 
        private string pathAPI;
        private static HttpClient clientAPIPortal;
        //Constructor
        public WSInstitucionesFinancierasxMunicipio()
        {
            //Solicitud solo el dominio, para tenerla persistente
            pathAPI = "https://www.datos.gov.co/resource/";

            clientAPIPortal = new HttpClient();
            clientAPIPortal.BaseAddress = new Uri(pathAPI);
            //Deja los encabezados por defecto
            clientAPIPortal.DefaultRequestHeaders.Accept.Clear();
            // Especifico el body de la peticion es decir el tipo de datos que voy a recibir.  
            clientAPIPortal.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
        }

        public async Task<RootObject> GetEntFinMunicipioAsync(string municipio)
        {
            //Instanciamos la clase que contiene la informacion
            RootObject EntidadesFinancieras = new RootObject ();
            //Concatenamos con el dominio la variable para crear la consulta
            string funcion = "ptgf-ywrb.xml?municipio=" + municipio.ToUpper();
            //Armamos la respuesta y la inicializamos vacia
            string respuesta = string.Empty;
            //Invocamos la clase de mensaje de respuesta
            HttpResponseMessage response = new HttpResponseMessage();
            response = await clientAPIPortal.GetAsync(funcion);
            if (response.IsSuccessStatusCode)
            {
                respuesta = await response.Content.ReadAsStringAsync();
                XmlDocument doc = new XmlDocument();
                //como el xml viene un string necesito pasarlo a un objeto xml
                doc.LoadXml(respuesta);
                //Convierto el xml a json
                var json = JsonConvert.SerializeXmlNode(doc, Formatting.None, true);
                //convierto el json en un objeto de c# con la estructura solicitada
                var entidades = JsonConvert.DeserializeObject<RootObject>(json);
                if (entidades.rows!=null)
                {
                    entidades.Estado = true;
                    entidades.Observacion = "OK";
                    EntidadesFinancieras = entidades;
                }
                else
                {
                    entidades.Estado = false;
                    entidades.Observacion = "No se enontraron Entidades";
                    EntidadesFinancieras = entidades;
                }
                
            }
            else
            {
                //Si no es OK mostramos la excepcion
                RootObject Respuesta = new RootObject();
                StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result, Encoding.UTF8);
                var responseBody = reader.ReadToEnd();
                Respuesta.Estado = false;
                Respuesta.Observacion = responseBody;
                throw new ArgumentException(JsonConvert.SerializeObject(Respuesta));
            }
            return EntidadesFinancieras;
        }
    }
}
