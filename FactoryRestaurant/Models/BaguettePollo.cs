using System;
using System.Collections.Generic;

namespace FactoryRestaurant.Models
{
    public class BaguettePollo : IBaguette
    {
        private List<Ingredientes> _ingredientes;

        public BaguettePollo(List<Ingredientes> ingredientes)
        {
            this._ingredientes = ingredientes;
        }

        public string PrepararBaguette()
        {
            return $"Baguette: {Baguettes.Pollo}, Pan: {Pan.Baguette}, Ingredientes: {string.Join(separator: ',', this._ingredientes)}";
        }
    }
}
