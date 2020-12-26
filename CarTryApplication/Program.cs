using System;

namespace CarTryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //// c1.Wyszukanie ogłoszenia po filtrze marki/id
            //// c2.Wybór ogłoszenia z listy
            //// c3.Przedstawienie wybranego szczegółowego ogłoszenia 
            ///

            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            ItemService itemService = new ItemService();
            Console.WriteLine("Welocome in first car test&try community");
            Console.WriteLine("Select what you want to do:");


            while (true)
            {
                var mainMenu = actionService.GetMenuActionsByName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }
                var operation = Console.ReadKey();
                
                Console.WriteLine();

                switch (operation.KeyChar)
                {
                    case '1':
                        string carBrand;
                        var keyInfo = itemService.AddNewItemView(actionService,out carBrand);
                        var id = itemService.AddNewItem(keyInfo.KeyChar, carBrand);
                        break;
                    case '2':
                        var removeId = itemService.RemoveItemView();
                        itemService.RemoveItem(removeId);
                        break;
                    case '3':
                        var detailId = itemService.ItemDetailSelectionView();
                        itemService.ItemDetailView(detailId);
                        break;
                    case '4':
                        var brandToShow = itemService.CarBrandTypeSelectionView();
                        itemService.CarBrandsByTypeView(brandToShow);
                        break;
                    default:
                        Console.WriteLine("Action you entered does not exist");
                        break;
                }
            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add the car that you can lend to test&try", "Main");
            actionService.AddNewAction(2, "Delete a car test&try announcement", "Main");
            actionService.AddNewAction(3, "Search a car to test&try", "Main");
            actionService.AddNewAction(4, "Search a model by car brand to test&try", "Main");

            actionService.AddNewAction(1, "Opel", "AddNewItemMenu");
            actionService.AddNewAction(2, "Volkswagen", "AddNewItemMenu");
            actionService.AddNewAction(3, "Toyota", "AddNewItemMenu");

            return actionService;
        }
    }
}
