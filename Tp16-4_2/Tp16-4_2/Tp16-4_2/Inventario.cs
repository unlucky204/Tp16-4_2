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
            ItemList.Add(item);
        }

        public void borrarItem(Item item)
        {
            ItemList.Remove(item);
        }
    }
}
