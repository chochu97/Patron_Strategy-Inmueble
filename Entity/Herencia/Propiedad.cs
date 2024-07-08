using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entity.Contracts
{
    public abstract class Propiedad
    {
        public string Ubicacion { get; set; }
        public string Localidad { get; set; }
        public decimal Precio {  get; set; }
    }
}
