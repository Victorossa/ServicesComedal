using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioComedalApi.Domain.Entity
{
    public class Row
    {
        public string nombreentidad { get; set; }
        public string codigoentidad { get; set; }
        public string municipio { get; set; }
        public string departamento { get; set; }
        public string tipo { get; set; }
    }
    public class Rows
    {
        public Rows()
        {
            row = new List<Row>();
        }
        public List<Row> row { get; set; }
    }

    public class RootObject
    {
        public RootObject()
        {
            //en caso de que no se tengan datos muestre
            rows = new Rows();
        }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
        public Rows rows { get; set; }

    }

}
