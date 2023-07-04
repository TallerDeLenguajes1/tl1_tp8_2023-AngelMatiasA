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
            String rutaArch = "";
            Console.WriteLine("ingrrese la ruta del archivo "); 
            rutaArch = Console.ReadLine();

            List<string> archivos = Directory.GetFiles(rutaArch).ToList<string>();

            Console.WriteLine(" Lista de archivos : "); 

            for (int i = 0; i < archivos.Count; i++)
            {
                Console.WriteLine($"archivo nro {i+1} nombre: {Path.GetFileName(archivos[i]) }");
            }

            string rutaArchCsv = "index.csv"; 
            using (StreamWriter escritor = new StreamWriter(rutaArchCsv))
            {
                escritor.WriteLine("Indice Nombre  Extension"); 
                for (int i = 0; i < archivos.Count; i++)
                {
                    string nombreArchivo = Path.GetFileNameWithoutExtension(archivos[i]);
                    string extensionArchivo = Path.GetExtension(archivos[i]); 
                    escritor.WriteLine($" {i+1}  {nombreArchivo}  {extensionArchivo }");

                }
                
            }

        }
    }
}