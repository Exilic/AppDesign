using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    public class RefinedProduct : Product
    {
        public override string ReturnName()
        {
            return base.Name;
        }
    }
}
