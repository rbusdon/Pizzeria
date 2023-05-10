using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileReader.Interfaces;

namespace FileReader
{
    public class CsvReader : ICsvReader
    {
        public List<string> ReadAllLines(string csvFilePath)
        {
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}
