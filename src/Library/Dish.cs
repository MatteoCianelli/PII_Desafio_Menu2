//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dish"/>.
        /// </summary>
        /// <param name="name">El nombre del platillo.</param>
        /// <param name="price">El precio del platillo.</param>
        /// <param name="isVegetarian">Indica si el platillo es vegetariano.</param>
        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }

        /// <summary>
        /// Obtiene o establece el nombre del platillo.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece el precio del platillo.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si el platillo es vegetariano.
        /// </summary>
        public bool IsVegetarian { get; set; }
    }
}