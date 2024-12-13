using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Sort
{
    public class MergeSort : ISort
    {
        public void Sort(IPrototype prototype)
        {
            MergeSortRec(prototype, 0, prototype.GetTamanho() - 1);
        }

        private void MergeSortRec(IPrototype prototype, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortRec(prototype, left, mid);
                MergeSortRec(prototype, mid + 1, right);
                Merge(prototype, left, mid, right);
            }
        }

        private void Merge(IPrototype prototype, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = ((ArrayPrototype)prototype).CompararValores(left + i, 0);
            for (int j = 0; j < n2; j++)
                rightArray[j] = ((ArrayPrototype)prototype).CompararValores(mid + 1 + j, 0);

            int iL = 0, iR = 0, k = left;

            while (iL < n1 && iR < n2)
            {
                if (leftArray[iL] <= rightArray[iR])
                {
                    ((ArrayPrototype)prototype).TrocarValores(k, left + iL);
                    iL++;
                }
                else
                {
                    ((ArrayPrototype)prototype).TrocarValores(k, mid + 1 + iR);
                    iR++;
                }
                k++;
            }

           
            while (iL < n1)
            {
                ((ArrayPrototype)prototype).TrocarValores(k, left + iL);
                iL++;
                k++;
            }

            while (iR < n2)
            {
                ((ArrayPrototype)prototype).TrocarValores(k, mid + 1 + iR);
                iR++;
                k++;
            }
        }
    }



}