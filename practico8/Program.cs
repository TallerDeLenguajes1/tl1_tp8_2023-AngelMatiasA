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
        ListaTarea  ManejoTareas = new ListaTarea(); 

        Console.WriteLine("Ingrese la cantidad de tareas: ");
            cantidad = Convert.ToInt32( Console.ReadLine());
            
           ManejoTareas.PedirTareas(cantidad); 
           ManejoTareas.mostrarTareas(ManejoTareas.ListaPendiente);
           ManejoTareas.moverTareas();
           Console.WriteLine("\n \n ***** \n \n ****** \nmuestro tareas realizadas");
           ManejoTareas.mostrarTareas(ManejoTareas.ListaRealizadas);
 


    
            

            
        
        
        }
    }
}