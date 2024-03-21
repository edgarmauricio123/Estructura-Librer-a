using METODOS_INGRESAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Visualizador
    {
       

        public static void IngresaAlumno(RegistroAlumno registro)
        {
            Console.WriteLine($"Matricula: {registro.Matricula.Numero}");
            Console.WriteLine($"Nombre: {registro.Persona.Nombre}");
            Console.WriteLine($"Apellido: {registro.Persona.Apellidos}");
            Console.WriteLine($"Carrera: {registro.Carrera.Nombre}"); 
            Console.WriteLine($"Grupo: {registro.Grupo.Nombre}"); 
                                                                                 
        }
    }

    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            

            Persona persona = new Persona(nombre, apellido);


           

 

            Console.WriteLine("\nIngrese los datos del grupo:");
            Console.Write("Nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            Grupo grupo = new Grupo(nombreGrupo);

            

           

            

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
