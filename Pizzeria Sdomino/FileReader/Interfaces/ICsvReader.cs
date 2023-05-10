using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Interfaces
{
    public interface ICsvReader
    {
        public List<string> ReadAllLines(string csvFilePath);
    }
}
