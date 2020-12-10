using System;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Menu Generator");

            Menu myMenu = new Menu()
            {
                RestaurantName = "The Nice Spot",
                LastUpdated = DateTime.Today
            };
            
            int menuDate = int.Parse(myMenu.LastUpdated.ToString("yyyyMMdd"));
            menuDate = menuDate - 1;
            Console.WriteLine("menuDate=" + menuDate);
            MenuItems myItem = new MenuItems("Toasted Ravioli", (decimal)14.99, "appetizer");
            int addDate = int.Parse(myItem.DateAdded.ToString("yyyyMMdd"));
            if (addDate > menuDate)
            {
                myItem.IsNew = true;
            }
            MenuItems myItem1 = new MenuItems("Ice Cream", (decimal)4.99, "dessert");
            addDate = int.Parse(myItem1.DateAdded.ToString("yyyyMMdd"));
            if (addDate > menuDate)
            {
                myItem1.IsNew = true;
            }
            MenuItems myItem2 = new MenuItems("Nachos", (decimal)10.99, "appetizer");
            addDate = int.Parse(myItem2.DateAdded.ToString("yyyyMMdd"));
            if (addDate > menuDate)
            {
                myItem2.IsNew = true;
            }
            MenuItems myItem3 = new MenuItems("Hamburger", (decimal)11.99, "main course");
            addDate = int.Parse(myItem3.DateAdded.ToString("yyyyMMdd"));
            if (addDate > menuDate)
            {
                myItem3.IsNew = true;
            }
            myMenu.AddItem(myItem);
            myMenu.AddItem(myItem1);
            myMenu.AddItem(myItem2);
            myMenu.AddItem(myItem3);
            Console.WriteLine("Printing the full menu");
            myMenu.PrintMenu();
            Console.WriteLine("Printing an item that is on the menu");
            myItem3.PrintItem();
            Console.WriteLine("Deleting" + myItem3.Description + " from the Menu");
            myMenu.DeleteItem(myItem3.Description);
            Console.WriteLine("Printing the full menu after the delete");
            myMenu.PrintMenu();

        }




    }
}
