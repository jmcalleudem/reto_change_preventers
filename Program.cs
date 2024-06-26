using reto_change_preventers;

class Program
{
    static void Main()
    {
        Restaurante restaurante = new Restaurante("El Buen Sabor");
        restaurante.AgregarMesero("Juan");
        restaurante.AgregarCocinero("Carlos");
        restaurante.AgregarPlatillo("Pizza", 10);
        restaurante.AgregarReserva("Reserva para 4 personas a las 7 PM");

        restaurante.GenerarReporte();

        Mesero mesero = new Mesero { Nombre = "Juan" };
        Cocinero cocinero = new Cocinero { Nombre = "Carlos" };
        mesero.TomarOrden();
        cocinero.PrepararComida();
    }
}