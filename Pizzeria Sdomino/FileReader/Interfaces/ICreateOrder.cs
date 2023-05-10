using DatabaseHandler.Models;

namespace FileReader.Interfaces
{
    public interface ICreateOrder
    {
        Order Waiter(string[] inputOrder);
    }
}