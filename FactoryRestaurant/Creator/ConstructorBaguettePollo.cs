using System;
using System.Collections.Generic;
using FactoryRestaurant.Models;

namespace FactoryRestaurant.Creator
{
    public class ConstructorBaguettePollo : Constructor
    {
        private List<Ingredientes> _ingredientes;

        public ConstructorBaguettePollo()
        {
            this._ingredientes = new List<Ingredientes>();
            this._ingredientes.Add(Ingredientes.Aguacate);
            this._ingredientes.Add(Ingredientes.Pollo);
            this._ingredientes.Add(Ingredientes.Chile);
            this._ingredientes.Add(Ingredientes.Aderezo);
            this._ingredientes.Add(Ingredientes.Lechuga);

        }

        public override IBaguette CrearBaguette()
        {
            return new BaguettePollo(this._ingredientes);
        }

        public override IHamburguesa CrearHamburguesa()
        {
            throw new NotImplementedException();
        }
    }
}
