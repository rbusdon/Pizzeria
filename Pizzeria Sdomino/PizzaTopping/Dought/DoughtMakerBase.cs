using PizzaTopping.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTopping.Dought
{
    public abstract class DoughtMakerBase : IPizzaMaker
    {
        public double GetCost()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public void SetNext(IPizzaMaker next)
        {
            throw new NotImplementedException();
        }
    }
}
