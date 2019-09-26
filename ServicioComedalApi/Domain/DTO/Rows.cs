using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServicioComedalApi.Domain.Entity
{
    public class Rows
    {
        [XmlElement(ElementName = "row")]
        public List<Row> Row { get; set; }
    }
}
