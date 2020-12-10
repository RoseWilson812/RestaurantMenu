using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        private List<MenuItems> menuList;
        public String RestaurantName { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu()
        {
            menuList = new List<MenuItems>();
        }
        public Menu(string name, DateTime upDate)
        {
            RestaurantName = name;
            LastUpdated = upDate;
            menuList = new List<MenuItems>();
        }

        public void PrintMenu()
        {
            //loop through menulist
            Console.WriteLine("Restaurant Name: " + this.RestaurantName);
            Console.WriteLine("Menu Revision Date: " + this.LastUpdated.ToString("MMMM dd, yyyy"));
            Console.WriteLine("***************** Menu ********************");
            foreach (MenuItems m in menuList)
            {
                m.PrintItem();

            }
            Console.WriteLine("***************** Thank You For Coming ********************");
            //compare Date Added > Last Update print new next to it
        }


        public void AddItem(MenuItems item)
        {
            menuList.Add(item);
        }
        public void AddItem(String description, decimal price, String category)
        {
            MenuItems aItem = new MenuItems(description, price, category);
            menuList.Add(aItem);

        }
        public void DeleteItem(string itemName)
        {

            foreach (MenuItems m in menuList)
            {
                if (m.Description.ToLower().Contains(itemName.ToLower()))
                {

                    menuList.Remove(m);
                    Console.WriteLine(itemName + " is removed from the list");
                    break;
                }
            }


        }
    }
}
