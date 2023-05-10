using DatabaseHandler.Models;

namespace FileReader.Interfaces
{
    public interface ICsvParser
    {
        List<Order> CsvParse(string csvFilePath);
    }
}