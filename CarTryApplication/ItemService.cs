using System;
using System.Collections.Generic;
using System.Text;

namespace CarTryApplication
{
    public class ItemService
    {
        public List<Item> Items { get; set; }

        public ItemService()
        {
            Items = new List<Item>();
        }

        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService, out string carBrand)
        {
            var addNewItemMenu = actionService.GetMenuActionsByName("AddNewItemMenu");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            int carBrandChoosed;
            Int32.TryParse(operation.KeyChar.ToString(), out carBrandChoosed);
            string carBrandChosed = addNewItemMenu[carBrandChoosed-1].Name;
            carBrand = carBrandChosed;
            return operation;
        }

        public int AddNewItem(char itemType, string carBrand)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);
            Item item = new Item();
            item.TypeId = itemTypeId;

            item.CarBrand = carBrand;

            Console.WriteLine("Enter id for new car announcement");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);

            Console.WriteLine("Please enter your car model");
            var model = Console.ReadLine();

            item.Id = itemId;
            item.CarModel = model;

            Items.Add(item);
            return itemId;
        }

        public int RemoveItemView()
        {
            Console.WriteLine("Enter id you want to delete: ");
            var itemId = Console.ReadLine();
            int id;
            Int32.TryParse(itemId.ToString(), out id);
            return id;
        }

        public void CarBrandsByTypeView(string carBrand)
        {
            List<Item> toShow = new List<Item>();
            foreach (var item in Items)
            {
                if (item.CarBrand == carBrand)
                {
                    toShow.Add(item);
                }
            }
            Console.WriteLine(toShow.ToStringTable(new[] { "Id", "Car Brand", "Car Model" }, a => a.Id, a => a.CarBrand, a => a.CarModel));
        }

        public string CarBrandTypeSelectionView()
        {
            Console.WriteLine("Enter car brand you want to show: ");
            var carBrand = Console.ReadLine();
            return carBrand;
        }

        public void RemoveItem(int removeId)
        {
            Item productToRemove = new Item();
            foreach (var item in Items)
            {
                if (item.Id == removeId)
                {
                    productToRemove = item;
                    break;
                }
            }

            Items.Remove(productToRemove);

        }

        public void ItemDetailView(int detailId)
        {
            Item productToShow = new Item();
            foreach (var item in Items)
            {
                if (item.Id == detailId)
                {
                    productToShow = item;
                    break;
                }
            }
            Console.WriteLine($"Car id: {productToShow.Id} ");
            Console.WriteLine($"Car brand: {productToShow.CarBrand} ");
            Console.WriteLine($"Car model: {productToShow.CarModel} ");
        }

        public int ItemDetailSelectionView()
        {
            Console.WriteLine("Enter id you want to show: ");
            var itemId = Console.ReadLine();
            int id;
            Int32.TryParse(itemId.ToString(), out id);
            return id;
        }
    }
}
