using System;
using System.Collections.Generic;
using FactoryRestaurant.Models;

namespace FactoryRestaurant.Creator
{
    public class ConstructorHamburguesaMexicana : Constructor
    {
        private List<Ingredientes> _ingredientes;

        public ConstructorHamburguesaMexicana()
        {
            this._ingredientes = new List<Ingredientes>();
            this._ingredientes.Add(Ingredientes.Aguacate);
            this._ingredientes.Add(Ingredientes.Carne);
            this._ingredientes.Add(Ingredientes.Cebolla);
            this._ingredientes.Add(Ingredientes.Chile);
            this._ingredientes.Add(Ingredientes.Jitomate);
            this._ingredientes.Add(Ingredientes.Lechuga);
            this._ingredientes.Add(Ingredientes.Mayonesa);
            this._ingredientes.Add(Ingredientes.Mostaza);
        }

        public override IBaguette CrearBaguette()
        {
            throw new NotImplementedException();
        }

        public override IHamburguesa CrearHamburguesa()
        {
            return new HamburguesaMexicana(this._ingredientes);
        }
    }
}
