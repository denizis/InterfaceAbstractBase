using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new SturbucsCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer { DateofBirth = new DateTime(2000,2,15), FirstName = "Deniz", LastName = "İskender", NationalityId= 555555, Id = 1 });



            Console.Read();

        }
    }
}
