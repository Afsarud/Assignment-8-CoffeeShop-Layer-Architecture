using System.Data;
using CoffeeShop.DAL;
using CoffeeShop.Model;

namespace CoffeeShop.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository=new ItemRepository();

        public bool UniqueItemName(Item item)
        {
            return _itemRepository.UniqueItemName(item);
        }

        public bool AddItem(Item item)
        {
            return _itemRepository.AddItem(item);
        }

        public DataTable Display()
        {
            return _itemRepository.Display();
        }

        public bool UpdateItem(Item item)
        {
            return _itemRepository.UpdateItem(item);
        }

        public bool DeleteItem(Item item)
        {
            return _itemRepository.DeleteItem(item);
        }

        public DataTable SearchItemByName(Item item)
        {
            return _itemRepository.SearchItemByName(item);
        }

    }
}
