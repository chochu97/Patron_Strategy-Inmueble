using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Departamento : Propiedad
    {
        public int CantidadAmbientes {  get; set; }
        public int Antiguedad {  get; set; }
        public int DepartamentosPorPiso {  get; set; }

        
    }
}
