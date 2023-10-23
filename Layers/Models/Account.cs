using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    public class Account : IAccount
    {
        private int id;
        private string name;
        private decimal balance;
        private int age;


        public int Id { get; set; }
        public int Age { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Account(int age)
        {
            Age = age;
        }

        public int ReturnThree()
        {
            return 3;
        }

        public virtual string ReturnAge()
        {
            return Age.ToString();
        }

    }
}
