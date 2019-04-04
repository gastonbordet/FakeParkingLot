using System;

namespace FakeParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            int Espacios = 100; // Cantidad de espacios para estacionar.
            int PrecioPorDia = 100; // Precio que se cobrara por la estadía de los vehículos.
            ControlPrograma control = new ControlPrograma(new ControlParking(new ParkingLot(Espacios, PrecioPorDia)));
            control.EjecutarPrograma();
        }
    }
}
