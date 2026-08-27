//------------------------------------------------------------------------------
// <copyright file="Waiter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private ArrayList assignedTables = new ArrayList();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Waiter"/>.
        /// </summary>
        /// <param name="name">El nombre del mozo.</param>
        public Waiter(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Obtiene o establece el nombre del mozo.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Asigna una mesa al mozo.
        /// </summary>
        /// <param name="table">La mesa que se asigna.</param>
        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }

        /// <summary>
        /// Registra un platillo en el pedido de una mesa.
        /// </summary>
        /// <param name="table">La mesa que realiza el pedido.</param>
        /// <param name="dish">El platillo solicitado.</param>
        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}