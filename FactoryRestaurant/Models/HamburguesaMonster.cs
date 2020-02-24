using System;
using System.Collections.Generic;

namespace FactoryRestaurant.Models
{
    public class HamburguesaMonster : IHamburguesa
    {
        private List<Ingredientes> _ingredientes;

        public HamburguesaMonster(List<Ingredientes> ingredientes)
        {
            this._ingredientes = ingredientes;
        }

        public string PrepararHamburguesa()
        {
            return $"Hamburguesa: {Hamburguesas.Monster}, Pan: {Pan.Hamburguesa}, Ingredientes: {string.Join(separator: ',', this._ingredientes)}";
        }
    }
}
