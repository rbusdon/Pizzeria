using DatabaseHandler.Models;
using FileReader.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace FileReader
{
    public class CsvParser : ICsvParser
    {
        private readonly ICsvReader _reader;
        private readonly ISplitter _splitter;
        private readonly IChecker _checker;
        private readonly ICreateOrder _createOrder;

        public CsvParser(ICsvReader reader, ISplitter splitter, IChecker checker, ICreateOrder createOrder)
        {
            _reader = reader;
            _splitter = splitter;
            _checker = checker;
            _createOrder = createOrder;
        }

        public List<Order> CsvParse(string csvFilePath)
        {
            List<string> lines = _reader.ReadAllLines(csvFilePath);

            List<Order> orders = new List<Order>();

            foreach (string line in lines)
            {
                string[] orderData = _splitter.SplitInputOrder(line);
                if (_checker.Check(orderData))
                {
                    orders.Add(_createOrder.Waiter(orderData));
                }
                else
                {
                    //sostituire con chiamata al logger
                    Console.WriteLine($"Invalid order data: {line}");
                }
            }

            return orders;
        }

    }
}