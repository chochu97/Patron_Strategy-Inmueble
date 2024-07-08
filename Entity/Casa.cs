using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Casa : Propiedad
    {
        public int CantidadAmbientes {  get; set; }
        public int Antiguedad {  get; set; }

        
    }
}
