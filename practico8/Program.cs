using System;
using EspacioListaTareas;
using espacioTareas;
using System.IO;

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
            /*elimino las tareas de la lista pendientes que se movieron a realizadas*/
            foreach (var realizadas in ManejoTareas.ListaRealizadas)
            {
                ManejoTareas.eliminarPorId(realizadas.ID);
            }

            /*Buscar Tarea*/
            do
            {

                do
                {
                    Console.WriteLine("desea buscar una tare ingrese 1 para si 2 para no");
                    entrada = Console.ReadLine();
                    valida = int.TryParse(entrada, out opcion);
                    if (!valida || (opcion != 2 && opcion != 1))
                    {
                        Console.WriteLine("Opcion no valida, intente nuevamente. ");

                    }
                } while (!valida || (opcion != 2 && opcion != 1));
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese la tarea a buscar ");

                    entrada = Console.ReadLine();
                    foreach (var pendiente in ManejoTareas.ListaPendiente)
                    {
                        if (pendiente.Descripcion.Equals(entrada))
                        {
                            Console.WriteLine("Tarea Encontrada en lista de pendientes ");
                            ManejoTareas.mostrarTarea(pendiente);
                            opcion = 0;

                        }

                    }
                    if (opcion == 1)
                    {

                        Console.WriteLine("Tarea no encontrada en lista de pendientes");
                        foreach (var pendiente in ManejoTareas.ListaRealizadas)
                        {
                            if (pendiente.Descripcion.Equals(entrada))
                            {
                                Console.WriteLine("Tarea Encontrada en lista de Realizadas ");
                                ManejoTareas.mostrarTarea(pendiente);
                                opcion = 0;

                            }
                          
                        }
                        if (opcion == 1)
                        {
                              
                                Console.WriteLine("Tarea no encontrada en lista de Realizadas");
                           
                            
                        }


                    }

                }
                else
                {
                    valida = false;
                }

            } while (valida);

            /*sumario de horas */
            string ruta = "Sumatoria.txt"; 
            // int totalHr = 0;

        //      foreach (var tarea in ManejoTareas.ListaRealizadas)
        // {
        //     totalHr += tarea.Duracion;
            
        // }
        // StreamWriter escritor = new StreamWriter(ruta);
        // escritor.WriteLine(" Total de horas trabajadas : ");
        
        // escritor.WriteLine($" Total: {totalHr}  ");
        ManejoTareas.sumatoriaDeHrs(ManejoTareas.ListaRealizadas, ruta);
         





            Console.WriteLine("\n \n ***** \n \n ****** \nmuestro tareas realizadas");
            ManejoTareas.mostrarTareas(ManejoTareas.ListaRealizadas);
            Console.WriteLine("\n \n ***** \n \n ****** \nmuestro tareas pendientes");


            ManejoTareas.mostrarTareas(ManejoTareas.ListaPendiente);









        }
    }
}