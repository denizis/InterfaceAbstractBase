using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        //Gerçek müşteri mi kontrol doğrulması.
        //Kişi Doğrulama kodları buraya yazılıcak
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
