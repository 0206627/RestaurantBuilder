using System;
using System.Collections.Generic;

namespace FactoryRestaurant.Models
{
    public class BaguetteVegetariano : IBaguette
    {
        private List<Ingredientes> _ingredientes;

        public BaguetteVegetariano(List<Ingredientes> ingredientes)
        {
            this._ingredientes = ingredientes;
        }

        public string PrepararBaguette()
        {
            return $"Baguette: {Baguettes.Vegetariano}, Pan: {Pan.Baguette}, Ingredientes: {string.Join(separator: ',', this._ingredientes)}";
        }
    }
}
