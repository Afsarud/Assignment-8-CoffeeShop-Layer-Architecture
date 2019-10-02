using CoffeeShop.DAL;
using System.Data;
using CoffeeShop.Model;

namespace CoffeeShop.BLL
{
    public class OrderManager
    {
        OrderRepository _orderRepository=new OrderRepository();

        public bool AddOrder(Order order)
        {
            double price = _orderRepository.GetItemPriceByItemId(order.ItemId);

            order.TotalPrice = price * order.Quantity;

            return _orderRepository.AddOrder(order);

        }

        public DataTable Display()
        {
            return _orderRepository.Display();
        }

        public DataTable GetAllItem()
        {
            return _orderRepository.GetAllItem();
        }

        public DataTable GetAllCustomer()
        {
            return _orderRepository.GetAllCustomer();
        }
    }
}
