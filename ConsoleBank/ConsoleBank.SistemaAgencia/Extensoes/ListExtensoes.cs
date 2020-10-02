using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T [] itens)//metodo generico
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
