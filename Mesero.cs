using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_change_preventers
{
    public class Mesero : Empleado
    {
        public void TomarOrden()
        {
            Console.WriteLine($"{Nombre} está tomando una orden.");
        }
    }
}
