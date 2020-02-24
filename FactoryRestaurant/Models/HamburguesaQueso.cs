using System;
using System.Collections.Generic;

namespace FactoryRestaurant.Models
{
    public class HamburguesaQueso : IHamburguesa
    {
        private List<Ingredientes> _ingredientes;

        public HamburguesaQueso(List<Ingredientes> ingredientes)
        {
            this._ingredientes = ingredientes;
        }

        public string PrepararHamburguesa()
        {
            return $"Hamburguesa: {Hamburguesas.Queso}, Pan: {Pan.Hamburguesa}, Ingredientes: {string.Join(separator: ',', this._ingredientes)}";
        }
    }
}
