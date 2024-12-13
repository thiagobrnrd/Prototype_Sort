using System;
namespace Prototype_Sort
{
    class Client
    {
        static void Main(string[] args)
        {
            int[] data = { 34, 7, 23, 32, 5, 62 };

            ArrayPrototype prototype = new ArrayPrototype(data);
            ContextSort context = new ContextSort();

            Console.WriteLine("Bubble Sort:");
            var bubbleClone = prototype.Clonar();
            context.SetSort(new BubbleSort());
            context.Sort(bubbleClone);
            bubbleClone.Imprimir();

            Console.WriteLine("Merge Sort:");
            var mergeClone = prototype.Clonar();
            context.SetSort(new MergeSort());
            context.Sort(mergeClone);
            mergeClone.Imprimir();

            Console.WriteLine("Quick Sort:");
            var quickClone = prototype.Clonar();
            context.SetSort(new QuickSort());
            context.Sort(quickClone);
            quickClone.Imprimir();
        }
    }
}
