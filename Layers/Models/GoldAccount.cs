using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    public class GoldAccount : Account
    {
        public string Title { get; set; }
        public GoldAccount(int age) : base(age)
        {
            Title = "Sr.";
        }
        public int ReturnNumber()
        {
            return 6;
        }

        public string ValueCustomer()
        {
            return Title;
        }

        public override string ReturnAge()
        {
            return Age.ToString() + ", " + Title;
        }
    }
}
