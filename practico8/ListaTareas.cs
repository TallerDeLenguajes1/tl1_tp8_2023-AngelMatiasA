namespace EspacioListaTareas;
using System;
using espacioTareas;

public class ListaTarea
{
    Tareas nuevaTarea;
    List<Tareas> listaPendiente;
    List<Tareas> listaRealizadas;

    public ListaTarea()
    {
        // Tareas nuevaTarea = new Tareas(); 
        listaPendiente = new List<Tareas>();
        listaRealizadas = new List<Tareas>();
        //  Tareas NuevaTarea;
    }

    public void PedirTareas(int n)
    {
        string aux;
        for (int i = 0; i < n; i++)
        {
            // Tareas tarea = new Tareas();
            /* Para pasar tareas necesitaria otro constructor q no inicialize en  con la variable estatica
            el contador id . */

            Console.WriteLine("Ingrese la descripcion de la tarea: ");
            aux = Console.ReadLine();
            Tareas tarea = new Tareas( aux);
            listaPendiente.Add(tarea);
            
        }
    }

    public void mostrarTareasPendietes()
    {

        foreach (var tarea in listaPendiente)
        {
            Console.WriteLine("  el id de la tarea es: ");
            Console.WriteLine(tarea.ID);
            Console.WriteLine("  la duracion de la tarea es: ");
            Console.WriteLine(tarea.Duracion);
            Console.WriteLine(" la descripcion de la tarea es: ");
            Console.WriteLine(tarea.Descripcion);
        }

        // for (int i = 0; i < n; i++)
        // { 
        //     Tareas NuevaTarea= new Tareas();
        //     Console.WriteLine("Ingrese la descripcion de la tarea: ");
        //  NuevaTarea.Descripcion=Console.ReadLine(); 
        //  listTarea.Add(NuevaTarea);



        // }


    }


    public List<Tareas> ListaPendiente { get => listaPendiente; set => listaPendiente = value; }
    public List<Tareas> ListaRealizadas { get => listaRealizadas; set => listaRealizadas = value; }
    public Tareas NuevaTarea { get => nuevaTarea; set => nuevaTarea = value; }
}