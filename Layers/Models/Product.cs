using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
   
        public int ReturnId()
        {
            return Id;
        }

        public abstract string ReturnName();
    }
}
