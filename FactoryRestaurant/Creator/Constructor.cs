using System;
using FactoryRestaurant.Models;

namespace FactoryRestaurant.Creator
{
    public abstract class Constructor
    {
        public abstract IHamburguesa CrearHamburguesa();
        public abstract IBaguette CrearBaguette();
    }
}
