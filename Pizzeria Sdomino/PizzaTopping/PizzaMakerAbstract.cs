using PizzaTopping.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTopping
{
    public abstract class PizzaMakerAbstract : IBasePizza
    {
        protected IPizzaMaker? _nextChecker;
        public abstract string GetDescription();
        public abstract double GetCost();
        public abstract void SetNext(IPizzaMaker next);
    }
}
