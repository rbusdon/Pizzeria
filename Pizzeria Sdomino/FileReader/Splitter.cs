using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileReader.Interfaces;

namespace FileReader
{
    public class Splitter : ISplitter
    {
        public string[] SplitInputOrder(string inputOrder) => inputOrder.Split(";");
    }
}
