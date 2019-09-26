using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComedalApi.Models
{
    public class InfoPaisClass
    {
        public string NombrePais { get; set; }
        public string ISOPais { get; set; }
        public string ISOMoneda { get; set; }
        public WSCountyInfo.tLanguage[] ListaIdiomas { get; set; }
        public string NombreMoneda { get; set; }

    }
}
