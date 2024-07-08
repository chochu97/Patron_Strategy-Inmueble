using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contracts
{
    internal class ConcreteStrategyDepto : IStrategyInmueble
    {
        public override decimal CalcularComision(decimal p)
        {
            decimal com = 0.1m;
            return (p * com);
        }

        public override decimal CalcularImpuesto(decimal p)
        {
            decimal imp = 0.01m;
            return (p * imp);
        }

        public override decimal CalcularTotal(decimal p)
        {
            return p + CalcularComision(p) + CalcularImpuesto(p);
        }
    }
}
