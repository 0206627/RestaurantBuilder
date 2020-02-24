using System;
using System.Collections.Generic;
using FactoryRestaurant.Models;

namespace FactoryRestaurant.Creator
{
    public class ConstructorHamburguesaMonster : Constructor
    {
        private List<Ingredientes> _ingredientes;

        public ConstructorHamburguesaMonster()
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
            this._ingredientes.Add(Ingredientes.Catsup);
            this._ingredientes.Add(Ingredientes.Queso);
            this._ingredientes.Add(Ingredientes.Mozarella);
        }

        public override IBaguette CrearBaguette()
        {
            throw new NotImplementedException();
        }

        public override IHamburguesa CrearHamburguesa()
        {
            return new HamburguesaMonster(this._ingredientes);
        }
    }
}
