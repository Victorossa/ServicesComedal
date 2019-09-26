using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioComedalApi.Domain.DTO
{
    public class InfoPaisClass
    {
        public bool Estado { get; set; }
        public string Observacion { get; set; }
        public string NombrePais { get; set; }
        public string ISOPais { get; set; }
        public string ISOMoneda { get; set; }
        public ServicioComedal.tLanguage[] ListaIdiomas { get; set; }
        public string NombreMoneda { get; set; }

    }
}
