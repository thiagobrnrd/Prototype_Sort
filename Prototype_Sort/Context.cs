using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Sort
{
    public class ContextSort
    {
        private ISort sortStrategy;

        public void SetSort(ISort strategy)
        {
            sortStrategy = strategy;
        }

        public void Sort(IPrototype prototype)
        {
            sortStrategy?.Sort(prototype);
        }
    }

}
