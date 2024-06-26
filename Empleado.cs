using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_change_preventers
{
    // Parallel Inheritance Hierarchies: Cada vez que se añade un nuevo tipo de empleado, se añade en dos lugares diferentes.
    public abstract class Empleado
    {
        public string Nombre { get; set; }
    }
}
