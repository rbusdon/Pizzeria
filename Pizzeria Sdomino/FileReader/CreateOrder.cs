using DatabaseHandler.Models;
using FileReader.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    public class CreateOrder : ICreateOrder
    {
        public Order Waiter(string[] inputOrder)
        {
            var order = new Order
            {
                BasePizza = inputOrder[0],
                Dought = inputOrder[1],
                Toppings = inputOrder[2]
            };
            return order;
        }
    }
}
