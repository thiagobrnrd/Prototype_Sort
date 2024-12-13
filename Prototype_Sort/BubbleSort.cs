using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Sort
{
    public class BubbleSort : ISort
    {
        public void Sort(IPrototype prototype)
        {
            int tamanho = prototype.GetTamanho();
            for (int i = 0; i < tamanho - 1; i++)
            {
                for (int j = 0; j < tamanho - i - 1; j++)
                {
                    if (prototype.CompararValores(j, j + 1) > 0)
                    {
                        prototype.TrocarValores(j, j + 1);
                    }
                }
            }
        }
    }


}
