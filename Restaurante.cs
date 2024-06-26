using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_change_preventers
{
    // Divergent Change: Clase Restaurante cambia por múltiples razones (gestión de personal, menú, reservas, etc.)
    public class Restaurante
    {
        public string Nombre { get; set; }
        public List<string> Meseros { get; set; } = new List<string>();
        public List<string> Cocineros { get; set; } = new List<string>();
        public List<string> Platillos { get; set; } = new List<string>();
        public List<int> Precios { get; set; } = new List<int>();
        public List<string> Reservas { get; set; } = new List<string>();

        public Restaurante(string nombre)
        {
            Nombre = nombre;
        }

        // Métodos que gestionan diferentes aspectos del restaurante
        public void AgregarMesero(string nombre)
        {
            Meseros.Add(nombre);
        }

        public void AgregarCocinero(string nombre)
        {
            Cocineros.Add(nombre);
        }

        public void AgregarPlatillo(string nombre, int precio)
        {
            Platillos.Add(nombre);
            Precios.Add(precio);
        }

        public void AgregarReserva(string reserva)
        {
            Reservas.Add(reserva);
        }

        public void GenerarReporte()
        {
            Console.WriteLine($"Restaurante: {Nombre}");
            Console.WriteLine("Meseros:");
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"- {mesero}");
            }
            Console.WriteLine("Cocineros:");
            foreach (var cocinero in Cocineros)
            {
                Console.WriteLine($"- {cocinero}");
            }
            Console.WriteLine("Menú:");
            for (int i = 0; i < Platillos.Count; i++)
            {
                Console.WriteLine($"- {Platillos[i]}: ${Precios[i]}");
            }
            Console.WriteLine("Reservas:");
            foreach (var reserva in Reservas)
            {
                Console.WriteLine($"- {reserva}");
            }
        }
    }
}
