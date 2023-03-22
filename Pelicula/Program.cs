using System;
using System.Collections.Generic;

namespace Pelicula
{

    // CLASE PELÍCULA
    public class Pelicula
    {
        //Campos Privados
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        
        //Constructores
        
        // Constructor Película
        public Pelicula(string titulo, Int16 año, string pais, string director)
            {
                this.titulo = titulo;
                this.año = año;
                this.pais = pais;
                this.director = director;
                
            }
        
        // Constructo Pelicula()
        public Pelicula()
        {
            titulo = "";
            año = 0;
        }
        
        // Constructor Pelicula(string titulo, Int16 año ) 
        public Pelicula(string titulo, Int16 año)
        {
            this.titulo = titulo;
            this.año = año;
        }
        
        
        //Métodos
          
        // Set
        
        // Set Titulo
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        
        // Set Año
        public void SetAño(Int16 año)
        {
            this.año = año;
        }
        
        // Set País
        public void SetPais(string pais)
        {
            this.pais = pais;
        }

        // Set Director
        public void SetDirector(string director)
        {
            this.director = director;
        }
        
        // Get
        
        // Get Titulo
        public string GetTitulo()
        {
            return titulo;
        }
        
        // Get Año
        public Int16 GetAño()
        {
            return año;
        }
        
        // Get País
        public string GetPais()
        {
            return pais;
        }
        
        // Get Director
        public string GetDirector()
        {
            return director;
        }
         
        // Imprime() sin modificar el código de Console.Writline()
        public void Imprime()
        {
            
            Console.WriteLine($"{titulo} ({año})");

        }
        
        // AgregaActor(Actor actor)
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        
        // ImprimeActores()
        public void ImprimeActores()
        {
            Console.WriteLine("Actores:");
             foreach (Actor actor in this.actores)
            {
                Console.WriteLine("{0} ({1})", actor.GetNombre(), actor.GetAñoNacimiento());
            }
}

    }

    // CLASE ACTOR
    public class Actor
    {
        //Propiedades
        public string Nombre;
        public Int16 AñoNacimiento;
        
        
        //Constructores
        
        // Constructor Actor
            public Actor(string Nombre, Int16 AñoNacimiento)
            {
                this.Nombre = Nombre;
                this.AñoNacimiento = AñoNacimiento;
            }

        //Métodos 
        
        // Set
        
        //Set Nombre
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        
        // Set AñoNacimiento
        public void SetAño(Int16 AñoNacimiento)
        {
            this.AñoNacimiento = AñoNacimiento;
        }
        
        // Get
        
        // Get Nombre
        public string GetNombre()
        {
            return Nombre;
        }
        
        // Get Año
        public Int16 GetAñoNacimiento()
        {
            return AñoNacimiento;
        }
        
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({AñoNacimiento})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            // Paso 4 de las tarea 
            
            // Objeto Pelicula p1
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            Actor actor1 = new Actor("Ryan Gosling", 1980); 
            Actor actor2 = new Actor("Emma Stone", 1988); 
            p1.AgregaActor(actor1);
            p1.AgregaActor(actor2);
            
            p1.ImprimeActores();
            
            // Objeto Pelicula p2
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("CODA");
            p2.SetAño(2021);
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
            
            // Lista de Películas
            List<Pelicula> peliculas = new List<Pelicula>();
           
            
            peliculas.Add(new Pelicula("Todo En Todas Partes Al Mismo Tiempo", 2022));
            peliculas.Add(new Pelicula("CODA", 2021));
            peliculas.Add(new Pelicula("Nomadland", 2020));
            peliculas.Add(new Pelicula("Parásitos", 2019));
            peliculas.Add(new Pelicula("Green Book: una amistad sin fronteras", 2018));
            
            foreach (Pelicula p in peliculas)
            {
                Console.WriteLine("{0} ({1})", p.GetTitulo(), p.GetAño());
            }
        }

    }
}
