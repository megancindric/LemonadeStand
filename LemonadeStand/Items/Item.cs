using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        static Item()
        {

        }
        
    }
}
