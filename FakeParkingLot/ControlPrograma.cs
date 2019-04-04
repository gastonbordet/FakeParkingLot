using System;
using System.Collections.Generic;
using System.Text;

namespace FakeParkingLot
{
    class ControlPrograma
    {
        private String Comandos;
        private ControlParking Parking;

        public ControlPrograma(ControlParking parking)
        {
            Comandos =
                "\n" +
                "--------------------COMANDOS----------------------\n" +
                "Abrir estacionamiento:                 abrir \n" +
                "Cerrar estacionamiento y facturar:     cerrar \n" +
                "Consultar espacios disponibles:        espacios \n" +
                "Consultar autos estacionados:          autos \n" +
                "Consultar precio por dia:              precio \n" + 
                "Ingresar auto:                         ingresar \n" +
                "Quitar auto:                           egresar \n" +
                "--------------------------------------------------\n" +
                "Ver comandos nuevamente:               comandos \n" +
                "Limpiar consola:                       limpiar \n" +
                "Salir del programa:                    salir \n" +
                "--------------------------------------------------\n";

            Parking = parking;
        }

        public void EjecutarPrograma()
        {
            bool flag = true;
            Console.WriteLine(Comandos);
            String comando = Console.ReadLine().ToString();

            while (flag)
            {
                
                switch(comando)
                {
                    case "salir":
                        flag = false;
                        break;

                    case "abrir":
                        Parking.AbrirEstacionamiento();
                        break;

                    case "cerrar":
                        Parking.CerrarEstacionamiento();
                        break;

                    case "espacios":
                        Parking.EspaciosDisponibles();
                        break;

                    case "autos":
                        Parking.AutosEstacionados();
                        break;

                    case "precio":
                        Parking.ConsultarPrecio();
                        break;

                    case "ingresar":
                        Parking.IngresaAuto();
                        break;

                    case "egresar":
                        Parking.EgresaAuto();
                        break;

                    case "comandos":
                        Console.WriteLine(Comandos);
                        break;

                    case "limpiar":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Ingrese un comando valido.");
                        break;
                }

                Console.WriteLine();
                comando = Console.ReadLine().ToString();
            }

            Console.WriteLine("Ha salido del programa.");
        }
    }
}
