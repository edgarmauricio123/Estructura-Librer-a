using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODOS_INGRESAR
{
    public class Matricula
    {
        private static int lastMatricula = 0;

        public int Numero { get; }

        public Matricula()
        {
            Numero = ++lastMatricula;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
       

        public Persona(string nombre, string apellidos )
        {
            Nombre = nombre;
            Apellidos = apellidos;
            
        }
    }

   
    public class Grupo
    {
        public string Nombre { get; set; }

        public Grupo(string nombre)
        {
            Nombre = nombre;
        }
    }
   
    public class RegistroAlumno
    {
        public Matricula Matricula { get; }
        public Persona Persona { get; }
        public Carrera Carrera { get; }
        public Grupo Grupo { get; }


        public RegistroAlumno(Persona persona, Carrera carrera,  Grupo grupo )
        {
            Matricula = new Matricula();
            Persona = persona;
            Carrera = carrera;
        }
    }

    public class Visualizador
    {

        public static void MostrarRegistroAlumno(RegistroAlumno registro)
        {
            Console.WriteLine($"Matricula: {registro.Matricula.Numero}");
            Console.WriteLine($"Nombre: {registro.Persona.Nombre}");
            Console.WriteLine($"Apellido: {registro.Persona.Apellidos}");
            Console.WriteLine($"Carrera: {registro.Carrera}");
          

            // Mostrar más detalles del registro según sea necesario
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
          

            Persona persona = new Persona(nombre, apellido);

            Console.WriteLine("\nIngrese los datos de la carrera:");
            Console.Write("Nombre de la carrera: ");
            string nombreCarrera = Console.ReadLine();

            Carrera carrera = new Carrera(nombreCarrera);

          


            Console.WriteLine("\nIngrese los datos del grupo:");
            Console.Write("Nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            Grupo grupo = new Grupo(nombreGrupo);

            Console.WriteLine("\nIngrese los datos del docente:");
            Console.Write("Nombre del docente: ");
            string nombreDocente = Console.ReadLine();

            Docente docente = new Docente(nombreDocente);

           

            RegistroAlumno registro = new RegistroAlumno(persona, carrera,  grupo  );

            Console.WriteLine("\nRegistro Alumno:");
            Visualizador.MostrarRegistroAlumno(registro);
        }
    }
}
