using System;
using System.Collections.Generic;

namespace FactoryRestaurant.Models
{
    public class HamburguesaMexicana : IHamburguesa
    {
        private List<Ingredientes> _ingredientes;

        public HamburguesaMexicana(List<Ingredientes> ingredientes)
        {
            this._ingredientes = ingredientes;
        }

        public string PrepararHamburguesa()
        {
            return $"Hamburguesa: {Hamburguesas.Mexicana}, Pan: {Pan.Hamburguesa}, Ingredientes: {string.Join(separator: ',', this._ingredientes)}";
        }
    }
}
