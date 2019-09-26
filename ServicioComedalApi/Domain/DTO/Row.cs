using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServicioComedalApi.Domain.Entity
{
    [XmlRoot(ElementName = "row")]
    public class Row
    {
        [XmlElement(ElementName = "codigoentidad")]
        public int Codigoentidad { get; set; }


        [XmlElement(ElementName = "departamento")]
        public string Departamento { get; set; }


        [XmlElement(ElementName = "municipio")]
        public string Municipio { get; set; }


        [XmlElement(ElementName = "nombreentidad")]
        public string Nombreentidad { get; set; }


        [XmlElement(ElementName = "tipo")]
        public string Tipo { get; set; }

    }
}
