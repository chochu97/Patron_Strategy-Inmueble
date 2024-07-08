using Datos.Contracts;
using Entity;
using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Venta
    {
        private static int ultimoNRO = 0;

        public int NRO {  get; set; }
        public DateTime FechaVenta { get; set; } 
        public Propiedad propiedad {  get; set; }

        private IStrategyInmueble inmStrategy; 

        public Venta(Propiedad inmueble) 
        {
            NRO = ++ultimoNRO;
            FechaVenta = DateTime.Now;
            
            propiedad = inmueble;
            
            if(propiedad.GetType().Name == "Casa")
            {
                this.inmStrategy = new ConcreteStrategyCasa();
            }
            else if (propiedad.GetType().Name == "Campo")
            {
                this.inmStrategy = new ConcreteStrategyCampo();
            }
            else if (propiedad.GetType().Name == "Departamento")
            {
                this.inmStrategy = new ConcreteStrategyDepto();
            }
            else if (propiedad.GetType().Name == "Local")
            {
                this.inmStrategy = new ConcreteStrategyLocal();
            }
        }

        public decimal CalcularComision()
        {
            decimal com = 0m;
            com = inmStrategy.CalcularComision(propiedad.Precio);
            return com;
        }

        public decimal CalcularImpuesto()
        {
            decimal imp = 0m;
            imp = inmStrategy.CalcularImpuesto(propiedad.Precio);
            return imp;
        }

        public decimal CalcularTotal()
        {
            decimal total = 0m;
            total = inmStrategy.CalcularTotal(propiedad.Precio);
            return total;
        }
    }
}
