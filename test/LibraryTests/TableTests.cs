//------------------------------------------------------------------------------
// <copyright file="TableTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using NUnit.Framework;

namespace Ucu.Poo.Restaurant.Tests
{
    [TestFixture]
    public class TableTests
    {
        [Test]
        public void Constructor_WithValidParameters_SetsProperties()
        {
            const int number = 1;
            Table table = new Table(number);

            Assert.That(table.Number, Is.EqualTo(number));
        }

        [Test]
        public void IsOccupied_WithOccupiedTable_ReturnsTrue()
        {
            Table table = new Table(1);

            table.Occupy();

            Assert.That(table.IsOccupied, Is.True);
        }

        [Test]
        public void HasOrders_BeforeAddOrder_ReturnsFalse()
        {
            Table table = new Table(1);

            Assert.That(table.HasOrders(), Is.False);
        }

        [Test]
        public void HasOrders_AfterAddOrder_ReturnsTrue()
        {
            Table table = new Table(1);
            table.Occupy();
            Dish dish = new Dish("Salad", 5.99, true);

            table.AddToOrder(dish);

            Assert.That(table.HasOrders(), Is.True);
        }

        [Test]
        public void Free_WithOccupiedTable_SetsIsOccupiedToFalseAndEmptiesOrder()
        {
            Table table = new Table(1);
            table.Occupy();
            Dish dish = new Dish("Salad", 5.99, true);
            table.AddToOrder(dish);

            table.Free();

            Assert.That(table.IsOccupied, Is.False);
            Assert.That(table.HasOrders(), Is.False);
        }

        /* Quita los siguientes comentarios para probar tu solución */
        [Test]
        public void GetTotal_BeforeAddDish_ReturnsZero()
        {
            Table table = new Table(1);
            table.Occupy();

            double expected = 0;
            double actual = table.GetTotal();

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetTotal_AfterAddDishes_ReturnsSumOfPrice()
        {
            Table table = new Table(1);
            table.Occupy();
            Dish salad = new Dish("Salad", 5.99, true);
            Dish burger = new Dish("Burger", 7.99, false);
            table.AddToOrder(salad);
            table.AddToOrder(burger);

            double expected = 5.99 + 7.99;
            double actual = table.GetTotal();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}