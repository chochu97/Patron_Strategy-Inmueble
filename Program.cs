using Entity;
using Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmob.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Propiedad campo = new Campo()
            {
                Localidad = "Vicente Lopez",
                Ubicacion = "Pringles 3232",
                Precio = 25000,
                Hectareas = 30,
                Electricidad = true,
                Forestada = true,
            };

            Propiedad casa = new Casa()
            {
                Localidad = "San Isidro",
                Ubicacion = "Washington 3232",
                Precio = 75000,
                Antiguedad = 20,
                CantidadAmbientes = 5,
            };

            Propiedad depto = new Departamento()
            {
                Localidad = "Palermo",
                Ubicacion = "Armenia 3434",
                Precio = 150000,
                DepartamentosPorPiso = 3,
                Antiguedad = 15,
                CantidadAmbientes = 3,
            };

            Propiedad local = new Local()
            {
                Localidad = "San Martin",
                Ubicacion = "Moreno 490",
                Precio = 305000,
                SuperficieCubierta = 3,
                SuperficieTotal = 19,
            };

            List<Propiedad> inmuebles = new List<Propiedad>();
            inmuebles.Add(campo);
            inmuebles.Add(casa);
            inmuebles.Add(local);
            inmuebles.Add(depto);

            foreach(Propiedad inm in inmuebles)
            {
                Venta venta = new Venta(inm);
                Console.WriteLine("Tipo Propiedad: {0}", inm.GetType().Name);
                Console.WriteLine("Valor Propiedad: " + venta.propiedad.Precio);
                Console.WriteLine("Total Boleto: " + venta.CalcularComision());
                Console.WriteLine("Total Impuesto: " + venta.CalcularImpuesto());
                Console.WriteLine("Total de la Propiedad: " + venta.CalcularTotal());
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
