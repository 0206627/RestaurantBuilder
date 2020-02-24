using System;
using System.Collections.Generic;
using FactoryRestaurant.Models;

namespace FactoryRestaurant.Creator
{
    public class ConstructorBaguetteVegetariano : Constructor
    {
        private List<Ingredientes> _ingredientes;

        public ConstructorBaguetteVegetariano()
        {
            this._ingredientes = new List<Ingredientes>();
            this._ingredientes.Add(Ingredientes.Aguacate);
            this._ingredientes.Add(Ingredientes.Aderezo);
            this._ingredientes.Add(Ingredientes.Lechuga);
            this._ingredientes.Add(Ingredientes.Queso);
            this._ingredientes.Add(Ingredientes.Mozarella);

        }

        public override IBaguette CrearBaguette()
        {
            return new BaguetteVegetariano(this._ingredientes);
        }

        public override IHamburguesa CrearHamburguesa()
        {
            throw new NotImplementedException();
        }
    }
}
