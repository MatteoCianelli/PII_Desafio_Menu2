
using System;
using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una orden en el restaurante.
    /// </summary>
    public class Order
    {
        private ArrayList order = new ArrayList();

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
        
        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in order)
            {
                total += dish.Price;
            }
            return total;
        }
    }
}