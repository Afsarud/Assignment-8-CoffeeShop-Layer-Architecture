using CoffeeShop.DAL;
using System.Data;
using CoffeeShop.Model;
namespace CoffeeShop.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository=new CustomerRepository();

        public bool CheckUniqueCustomerName(Customer customer)
        {
            return _customerRepository.CheckUniqueCustomerName(customer);
        }

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public DataTable Display()
        {
            return _customerRepository.Display();
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public DataTable SearchCustomerByName(Customer customer)
        {
            return _customerRepository.SearchCustomerByName(customer);
        }

    }
}
