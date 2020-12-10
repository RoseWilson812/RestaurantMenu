using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItems
    {
        private decimal _price;
        //private String _description;
        //private String _category;
        //private DateTime _dateAdded;
        //private Boolean _isNew;

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public String Description { get; set; }
        public String Category { get; set; }
        public DateTime DateAdded { get; set; }

        public Boolean IsNew { get; set; }

        public MenuItems(String description, decimal price, String category, DateTime dateAdded, Boolean isNew)
        {
            Description = description;
            Price = price;
            Category = category;
            DateAdded = dateAdded;
            IsNew = isNew;

        }
        public MenuItems(String description, decimal price, String category)
        {
            Description = description;
            Price = price;
            Category = category;
            DateAdded = DateTime.Today;
            IsNew = false;

        }
        public void PrintItem()
        {
            if (this.IsNew == true)
            {
                Console.WriteLine("\n**** NEW ****");
            }
            Console.Write("Menu Item : " + this.Description + "\nPrice : " + this.Price.ToString("c"));
            Console.Write("\nCategory: " + this.Category);
            Console.Write("\nDate Added to Menu: " + this.DateAdded.ToString("MMMM dd, yyyy") + "\n");
            
            
        }







    }
}
