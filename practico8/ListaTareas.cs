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

            Console.WriteLine($"  \n      *********  ********* \n Ingrese la descripcion de la tarea numero: {i+1}. ");
            aux = Console.ReadLine();
            Tareas tarea = new Tareas(aux);
            listaPendiente.Add(tarea);
            /*ahora si para pedir las primeras tareas de pendientes les genero el id, 
            para las otras cuando las añada solo les copio el valor de la original */
        }
    }

    public void mostrarTareas(List<Tareas> lista)
    {   

        /*Le puedo pasar por parametro la lista y crear una variable 
        contador para el num de tarea*/
        int contador = 0;
        foreach (var tarea in lista)
        { 

            Console.WriteLine($" \n *********    ********* \n TAREA NRO : {++contador}.");
            Console.WriteLine($"  El id de la tarea es: {tarea.ID} ");
            Console.WriteLine($"   La duracion de la tarea es: {tarea.Duracion} ");
            Console.WriteLine($"  La descripcion de la tarea es: {tarea.Descripcion} ");
           
        }

    }


    public List<Tareas> ListaPendiente { get => listaPendiente; set => listaPendiente = value; }
    public List<Tareas> ListaRealizadas { get => listaRealizadas; set => listaRealizadas = value; }
    public Tareas NuevaTarea { get => nuevaTarea; set => nuevaTarea = value; }
}