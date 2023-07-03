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
                Console.WriteLine($"archivo nro {i} nombre: {Path.GetFileName(archivos[i]) }");
            }

        }
    }
}