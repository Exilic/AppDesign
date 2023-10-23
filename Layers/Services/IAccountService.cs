using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Services
{
    public interface IAccountService
    {
        bool Add(string name, int age);
        void Remove();
        void Edit();
        void GetAll();
    }
}
