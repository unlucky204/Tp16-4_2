using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp16_4_2
{
    public class Inventario
    {
        public List<Item> ItemList = new List<Item>();

        public void AñadirItem(Item item)
        {
            Item NuevoItem = item;
            ItemList.Add(NuevoItem);
            NuevoItem.Id = ItemList.LastIndexOf(NuevoItem);
            Console.WriteLine($"se agrego un item en la posicion {NuevoItem.Id}");
        }

        public void borrarItem(Item item)
        {
            Item NuevoItem = item;
            ItemList.RemoveAt(NuevoItem.Id);
            Console.WriteLine($"se Borro un item en la posicion {NuevoItem.Id}");
        }
    }
}
