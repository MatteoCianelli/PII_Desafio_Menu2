//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private ArrayList order = new ArrayList();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Table"/>.
        /// </summary>
        /// <param name="number">El número de la mesa.</param>
        public Table(int number)
        {
            this.Number = number;
        }

        /// <summary>
        /// Obtiene o establece el número de la mesa.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si la mesa está ocupada.
        /// </summary>
        public bool IsOccupied { get; set; }

        /// <summary>
        /// Marca la mesa como ocupada.
        /// </summary>
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        /// <summary>
        /// Libera la mesa y limpia los pedidos registrados.
        /// </summary>
        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        /// <summary>
        /// Agrega un platillo al pedido de la mesa.
        /// </summary>
        /// <param name="dish">El platillo que se agrega al pedido.</param>
        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        /// <summary>
        /// Indica si la mesa tiene pedidos registrados.
        /// </summary>
        /// <returns><see langword="true"/> si tiene pedidos; de lo contrario, <see langword="false"/>.</returns>
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}