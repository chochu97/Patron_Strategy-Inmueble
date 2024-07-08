using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Campo : Propiedad
    {
        public int Hectareas {  get; set; }
        public bool Electricidad { get; set; }
        public bool Forestada { get; set; }

        

        
    }
}
