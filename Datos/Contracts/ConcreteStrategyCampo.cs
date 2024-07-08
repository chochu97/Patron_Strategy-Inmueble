using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contracts
{
    internal class ConcreteStrategyCampo : IStrategyInmueble
    {
        public override decimal CalcularComision(decimal p)
        {
            decimal comision = 0.1m;
            return (p * comision);
        }

        public override decimal CalcularImpuesto(decimal p)
        {
            decimal impuesto = 0.1m;
            return (p * impuesto);
        }

        public override decimal CalcularTotal(decimal p)
        {
            return p + CalcularComision(p) + CalcularImpuesto(p);
        }
    }
}
