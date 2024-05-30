using System;
using System.Threading.Channels;

namespace Herencia_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación de objetos de las subclases
            Caballo PisaHondo = new Caballo();
            Humano Hamel = new Humano();
            Gorila Blanquito = new Gorila();


            //Caballo subClase de mamíferos
            Console.WriteLine("Caballo");
            PisaHondo.CuidarCrias();/*El método Respirar fue creado en la clase Mamíferos
            y a su vez es heredado por la clase Caballo*/

            PisaHondo.Galopar();//El método Galopar es únicamente de la clase Caballo

            Console.WriteLine("\nHumano");
            Hamel.Comer();//La clase Humano hereda el método comer de la clase Mamíferos
            
            Hamel.Cantar(); //El método Cantar es únicamente de la clase Humano

            Console.WriteLine("\nGorila");
            Blanquito.Respirar();
            
            Blanquito.Trepar();

        }
    }
    
    class Mamiferos
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void Comer()
        {
            Console.WriteLine("Soy capaz de comer");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Me hago cargo de mis crías");
        }
    }
    class Humano : Mamiferos
    {
        public void Cantar()
        {
            Console.WriteLine("Soy capaz de cantar");
        }
    }
    class Caballo: Mamiferos
    {
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    class Gorila : Mamiferos
    {
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
