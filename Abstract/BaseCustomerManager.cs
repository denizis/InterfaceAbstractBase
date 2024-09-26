using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    //Nero ve Sturbucks  aynı kodu içereceği için Abstract yöntemi ile tek kod yazımı ile 
    //her iki class a kodumuzu ekleyebiliyoruz.

    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db :"+customer.FirstName);
        }
    }
}
