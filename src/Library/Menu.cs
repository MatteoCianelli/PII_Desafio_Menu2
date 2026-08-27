//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private ArrayList dishes = new ArrayList();

        /// <summary>
        /// Agrega un platillo al menú.
        /// </summary>
        /// <param name="dish">El platillo que se desea agregar.</param>
        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        /// <summary>
        /// Quita un platillo del menú.
        /// </summary>
        /// <param name="dish">El platillo que se desea quitar.</param>
        public void RemoveDish(Dish dish)
        {
            this.dishes.Remove(dish);
        }

        /// <summary>
        /// Busca un platillo por su nombre.
        /// </summary>
        /// <param name="name">El nombre del platillo a buscar.</param>
        /// <returns>El platillo encontrado o <see langword="null"/> si no existe.</returns>
        public Dish GetDishByName(string name)
        {
            foreach (Dish dish in this.dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }

            return null;
        }
    }
}