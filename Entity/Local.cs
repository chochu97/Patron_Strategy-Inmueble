using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Local : Propiedad
    {
        public int SuperficieTotal { get; set; }
        public int SuperficieCubierta {  get; set; }

       
    }
}
