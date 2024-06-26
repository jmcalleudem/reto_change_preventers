using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_change_preventers
{
    public class Cocinero : Empleado
    {
        public void PrepararComida()
        {
            Console.WriteLine($"{Nombre} está preparando comida.");
        }
    }
}
