using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Sort
{
    public interface IPrototype
    {
        int GetTamanho();
        int CompararValores(int index1, int index2);
        void TrocarValores(int index1, int index2);
        void Imprimir();
        IPrototype Clonar();
    }

}
