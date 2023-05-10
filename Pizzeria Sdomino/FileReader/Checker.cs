using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileReader.Interfaces;

namespace FileReader
{
    public class Checker : IChecker
    {
        public bool Check(string[] inputOrder) => inputOrder.Length == 3;
    }
}
