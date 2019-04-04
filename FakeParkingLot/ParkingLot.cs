using System;
using System.Collections.Generic;
using System.Text;

namespace FakeParkingLot
{
    class ParkingLot : IParkingLot
    {
        
        public int CantidadEstacionados { get; set; }
        public int EspaciosDisponibles { get; set; }
        public int PrecioPorDia { get; set; }

        public ParkingLot(int max = 100, int precio = 100)
        {
            EspaciosDisponibles = max;
            CantidadEstacionados = 0;
            PrecioPorDia = precio;
        }

        public void IngresoDetectado()
        {
            EspaciosDisponibles--;
            CantidadEstacionados++;
        }

        public void EgresoDetectado()
        {
            CantidadEstacionados--;
            EspaciosDisponibles++;
            
        }

        public void FacturarEstadia(int Precio)
        {
            int Facturacion = CantidadEstacionados * Precio;
            
            String Asunto = "Facturación Estacionamiento";
            String Cuerpo = "Hay un total de " + CantidadEstacionados + " autos estacionados. La facturación del día es $" + Facturacion + ".";
            String Destinatario = "fakeparkinglot@gmail.com"; // Ingresar dirección de correo donde desea recibir la información.

            Console.WriteLine(Cuerpo);
            ServicioExterno.EnviarMail(Asunto, Cuerpo, Destinatario);
        }
    }
}
