using System;
using System.Collections.Generic;
using FactoryRestaurant.Models;

namespace FactoryRestaurant.Creator
{
    public class ConstructorBaguetteGriego : Constructor
    {
        private List<Ingredientes> _ingredientes;

        public ConstructorBaguetteGriego()
        {
            this._ingredientes = new List<Ingredientes>();
            this._ingredientes.Add(Ingredientes.Aderezo);
            this._ingredientes.Add(Ingredientes.Lechuga);
            this._ingredientes.Add(Ingredientes.Jitomate);
            this._ingredientes.Add(Ingredientes.Mozarella);
            this._ingredientes.Add(Ingredientes.Cebolla);

        }

        public override IBaguette CrearBaguette()
        {
            return new BaguetteGriego(this._ingredientes);
        }

        public override IHamburguesa CrearHamburguesa()
        {
            throw new NotImplementedException();
        }
    }
}
