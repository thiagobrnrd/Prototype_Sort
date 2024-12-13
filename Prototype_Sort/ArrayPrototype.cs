using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Sort
{
    public class ArrayPrototype : IPrototype
    {
        private int[] array;

        public ArrayPrototype(int[] array)
        {
            this.array = (int[])array.Clone();
        }

        public int GetTamanho() => array.Length;

        public int CompararValores(int index1, int index2) => array[index1].CompareTo(array[index2]);

        public void TrocarValores(int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public void Imprimir()
        {
            Console.WriteLine(string.Join(", ", array));
        }

        public IPrototype Clonar()
        {
            return new ArrayPrototype(this.array);
        }
    }


}
