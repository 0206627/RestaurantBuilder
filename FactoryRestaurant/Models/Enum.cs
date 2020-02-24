using System;
namespace FactoryRestaurant.Models
{
    public enum Hamburguesas
    {
        Queso = 1,
        Mexicana,
        Monster
    }

    public enum Baguettes
    {
        Pollo = 1,
        Vegetariano,
        Griego
    }

    public enum Ingredientes
    {
        Pollo,
        Lechuga,
        Carne,
        Jitomate,
        Queso,
        Chile,
        Aguacate,
        Mozarella,
        Aderezo,
        Cebolla,
        Mostaza,
        Mayonesa,
        Catsup
    }

    public enum Pan
    {
        Hamburguesa,
        Baguette
    }

}
