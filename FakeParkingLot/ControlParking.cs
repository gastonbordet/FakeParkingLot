using System;
using System.Collections.Generic;
using System.Text;

namespace FakeParkingLot
{
    class ControlParking
    {
        public ParkingLot Estacionamiento;
        public bool Estado { get; set; }

        public ControlParking(ParkingLot parking)
        {
            Estacionamiento = parking;
            Estado = false;
        }

        public void AbrirEstacionamiento()
        {
            if (Estado)
            {
                Console.WriteLine("El estacionamiento ya esta abierto.");
            }
            
            else
            {
                Console.WriteLine("El estacionamiento ahora esta abierto.");
                Estado = true;
            }
        }

        public void CerrarEstacionamiento()
        {
            if (!Estado)
            {
                Console.WriteLine("El estacionamiento no esta abierto.");
            }

            else
            {
                int PrecioPorDia = Estacionamiento.PrecioPorDia;
                Estacionamiento.FacturarEstadia(PrecioPorDia);
                Estado = false;
            }
        }

        public void IngresaAuto()
        {
            if (!Estado)
            {
                Console.WriteLine("El estacionamiento no esta abierto.");
            }

            else
            {
                if (Estacionamiento.EspaciosDisponibles >= 1)
                {
                    Estacionamiento.IngresoDetectado();
                    Console.WriteLine("Un auto ingresó al estacionamiento.");
                }

                else
                {
                    Console.WriteLine("No quedan espacios disponibles.");
                }
            }
            
        }

        public void EgresaAuto()
        {

            if (!Estado)
            {
                Console.WriteLine("El estacionamiento no esta abierto.");
            }

            else
            {
                if (Estacionamiento.CantidadEstacionados >= 1)
                {
                    Estacionamiento.EgresoDetectado();
                    Console.WriteLine("Un auto salió del estacionamiento.");
                }

                else
                {
                    Console.WriteLine("No hay autos estacionados.");
                }
            }
            
        }

        public void EspaciosDisponibles()
        {
            if (!Estado)
            {
                Console.WriteLine("El estacionamiento no esta abierto.");
            }

            else
            {
                Console.WriteLine("Hay " + Estacionamiento.EspaciosDisponibles.ToString() + " espacios disponibles.");
            }
        }
        
        public void AutosEstacionados()
        {
            if (!Estado)
            {
                Console.WriteLine("El estacionamiento no esta abierto.");
            }

            else
            {
                Console.WriteLine("Hay " + Estacionamiento.CantidadEstacionados.ToString() + " autos estacionados.");
            }   
        }

        public void ConsultarPrecio()
        {
            Console.WriteLine("El precio por dia es: $" + Estacionamiento.PrecioPorDia.ToString() + ".");
        }
    }
}
