using System;
using EspacioListaTareas;
using espacioTareas;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    { 

        // public void PedirTareas( int n, List<Tareas> listTarea){  

            
        //     for (int i = 0; i < n; i++)
        //     { 
        //         Tareas NuevaTarea= new Tareas();
        //         Console.WriteLine("Ingrese la descripcion de la tarea: ");
        //      NuevaTarea.Descripcion=Console.ReadLine(); 
        //      listTarea.Add(NuevaTarea);


                
        //     }


        // }
        static void Main(string[] args)
        {
            int cantidad = 0;
        ListaTarea  ManejoTareas = new ListaTarea(); 

        Console.WriteLine("Ingrese la cantidad de tareas: ");
            cantidad = Convert.ToInt32( Console.ReadLine());
            

           ManejoTareas.PedirTareas(cantidad); 

           ManejoTareas.mostrarTareasPendietes();

    
            

            
        
        
        }
    }
}