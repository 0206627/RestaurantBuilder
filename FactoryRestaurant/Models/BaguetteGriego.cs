using System;
using System.Collections.Generic;

namespace FactoryRestaurant.Models
{
    public class BaguetteGriego : IBaguette
    {
        private List<Ingredientes> _ingredientes;

        public BaguetteGriego(List<Ingredientes> ingredientes)
        {
            this._ingredientes = ingredientes;
        }

        public string PrepararBaguette()
        {
            return $"Baguette: {Baguettes.Griego}, Pan: {Pan.Baguette}, Ingredientes: {string.Join(separator: ',', this._ingredientes)}";
        }
    }
}
