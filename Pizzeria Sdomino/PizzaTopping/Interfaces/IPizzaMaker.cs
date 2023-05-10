using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTopping.Interfaces
{
    public interface IPizzaMaker
    {
        public string GetDescription();
        public double GetCost();
        public void SetNext(IPizzaMaker next);
    }
}
