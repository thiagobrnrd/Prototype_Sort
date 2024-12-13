using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Sort
{
    public class QuickSort : ISort
    {
        public void Sort(IPrototype prototype)
        {
            QuickSortRec(prototype, 0, prototype.GetTamanho() - 1);
        }

        private void QuickSortRec(IPrototype prototype, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(prototype, low, high);

                QuickSortRec(prototype, low, pi - 1);
                QuickSortRec(prototype, pi + 1, high);
            }
        }

        private int Partition(IPrototype prototype, int low, int high)
        {
            int pivot = ((ArrayPrototype)prototype).CompararValores(high, 0);
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (((ArrayPrototype)prototype).CompararValores(j, high) <= 0)
                {
                    i++;
                    prototype.TrocarValores(i, j);
                }
            }
            prototype.TrocarValores(i + 1, high);
            return i + 1;
        }
    }


}
