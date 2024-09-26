using InterfaceAbstractDemo;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    //Abstract ekledik BaseCustomer eklendiği için
    public abstract class SturbucsCustomerManager : BaseCustomerManager

    {
      private ICustomerCheckService _customerCheckService;


        public SturbucsCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //Kişi doğrulama kodu buradan çağrılıyor.


            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else
            {
                throw new Exception("Not valid person");
            }

            


        }
    }
}



