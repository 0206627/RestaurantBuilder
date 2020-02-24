using System;
using FactoryRestaurant.Creator;
using FactoryRestaurant.Models;

namespace FactoryRestaurant
{
    class Program
    {
        static int opcion = 0;
        
        static void Main(string[] args)
        {
            var result = Menu();

            if (result == -1)
            {
                Console.WriteLine("Error: Opción inválida");
                return;
            }

            else if (result == 1)
            {

                Constructor hamburguesa = null;

                Hamburguesas respuesta = (Hamburguesas)opcion;

                switch (respuesta)
                {
                    case Hamburguesas.Queso:
                        hamburguesa = new ConstructorHamburguesaQueso();
                        break;
                    case Hamburguesas.Mexicana:
                        hamburguesa = new ConstructorHamburguesaMexicana();
                        break;
                    case Hamburguesas.Monster:
                        hamburguesa = new ConstructorHamburguesaMonster();
                        break;
                }

                IHamburguesa hamburguesaPreparada = hamburguesa.CrearHamburguesa();
                Console.WriteLine(hamburguesaPreparada.PrepararHamburguesa());

            } else
            {

                Constructor baguette = null;

                Baguettes respuesta = (Baguettes)opcion;

                switch (respuesta)
                {
                    case Baguettes.Pollo:
                        baguette = new ConstructorBaguettePollo();
                        break;
                    case Baguettes.Vegetariano:
                        baguette = new ConstructorBaguetteVegetariano();
                        break;
                    case Baguettes.Griego:
                        baguette = new ConstructorBaguetteGriego();
                        break;
                }

                IBaguette baguettePreparado = baguette.CrearBaguette();
                Console.WriteLine(baguettePreparado.PrepararBaguette());

            }

        }

        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona comida:");
            Console.WriteLine("1. Hamburguesa");
            Console.WriteLine("2. Baguette");

            var x = Console.ReadLine();
            var numero = int.Parse(x);

            if (numero == 1)
            {
                opcion = MenuHamburguesa();
                return 1;
            }

            else if (numero == 2)
            {
                opcion = MenuBaguette();
                return 2;
            }

            else return -1;

        }

        public static int MenuHamburguesa()
        {
            Console.WriteLine("Selecciona una hamburguesa:");
            Console.WriteLine("1. Queso");
            Console.WriteLine("2. Mexicana");
            Console.WriteLine("3. Monster");

            var x = Console.ReadLine();

            try
            {
                var numero = int.Parse(x);

                if (numero >= 1 && numero <= 3) return numero;

                return -1;

            }
            catch
            {
                return -1;
            }
        }

        public static int MenuBaguette()
        {
            Console.WriteLine("Selecciona un baguette:");
            Console.WriteLine("1. Pollo");
            Console.WriteLine("2. Vegetariano");
            Console.WriteLine("3. Griego");

            var x = Console.ReadLine();

            try
            {
                var numero = int.Parse(x);

                if (numero >= 1 && numero <= 3) return numero;

                return -1;

            }
            catch
            {
                return -1;
            }
        }
    }
}
