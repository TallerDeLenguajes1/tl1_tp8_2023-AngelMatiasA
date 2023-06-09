namespace espacioTareas; 

public class Tareas
{
    public static int TareaID = 0; //Numerado en ciclo iterativo
    public string Descripcion = ""; //
    public int Duracion; // entre 10 – 100  
    public int ID;
 
//      public string Descripcion{ get => Descripcion; set => Descripcion = value; }
// public string getDescripcion (){
//     return this.Descripcion;
// }
    public Tareas(){
        this.ID = TareaID++;
         Random myObject = new Random();
        this.Duracion= myObject.Next(10, 100);
    }
    public Tareas (string Descripcion){ 
        this.Descripcion = Descripcion;  
        this.ID = TareaID++;
         Random myObject = new Random();
        this.Duracion= myObject.Next(10, 100);

    }  



    
}