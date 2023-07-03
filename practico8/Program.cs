using System;
using EspacioListaTareas;
using espacioTareas;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int cantidad = 0;
            string entrada = "";
            bool valida = true;
            int opcion = 0;
            ListaTarea ManejoTareas = new ListaTarea();

            Console.WriteLine("Ingrese la cantidad de tareas: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            ManejoTareas.PedirTareas(cantidad);
            ManejoTareas.mostrarTareas(ManejoTareas.ListaPendiente);
            ManejoTareas.moverTareas();
            foreach (var realizadas in ManejoTareas.ListaRealizadas)
            {
                ManejoTareas.eliminarPorId(realizadas.ID);


            }

            do
            {

                do
                {
                    Console.WriteLine("desea buscar una tare ingrese 1 para si 2 para no");
                    entrada = Console.ReadLine();
                    valida = int.TryParse(entrada, out opcion);
                    if (!valida || (opcion != 0 && opcion != 1))
                    {
                        Console.WriteLine("Opcion no valida, intente nuevamente. ");

                    }
                } while (!valida || (opcion != 0 && opcion != 1));
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese la tarea a buscar ");
                    
                    entrada = Console.ReadLine();
                    foreach (var pendiente in ManejoTareas.ListaPendiente)
                    {
                        if (pendiente.Descripcion.Equals(entrada))
                        {
                             Console.WriteLine("Tarea Encontrada ");

                            
                        }
                    }
                    
                }

            } while (valida);
            Console.WriteLine("\n \n ***** \n \n ****** \nmuestro tareas realizadas");
            ManejoTareas.mostrarTareas(ManejoTareas.ListaRealizadas);
            Console.WriteLine("\n \n ***** \n \n ****** \nmuestro tareas pendientes");


            ManejoTareas.mostrarTareas(ManejoTareas.ListaPendiente);









        }
    }
}