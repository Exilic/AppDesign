using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    public class PremierGoldAccount : GoldAccount
    {
        public string Treat  { get; set; }
        public int ReturnSomething()
        {
            return base.ReturnNumber();
        }

        public PremierGoldAccount(int age) : base(age)
        {
            Treat = "Lollipop";
        }

        public new string ValueCustomer()
        {
            return Treat;
        }
    }
}
