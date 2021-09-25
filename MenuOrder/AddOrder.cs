using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCheckAzure.Models;
using PracticeCheckAzure.Controllers;

namespace MenuOrder
{
    public class AddOrder
    {
        int id = 1;
        bool flag = true;
        public AddOrder()
        {
            List<Cart> cartItems = new List<Cart>();
            while(id>0)
            {
                Console.WriteLine("Enter menu Item Id to add to cart : ");
                id = Convert.ToInt32(Console.ReadLine());

                var findItemWithId = new MenuItemController().Get(id);
                if(cartItems.Find(x=>x.menuItemId == id)!=null && cartItems.Count!=0)
                {
                    flag = false;
                }
                if(findItemWithId!=null && flag)
                {
                    var order = new OrderController().Post(id);
                    cartItems.Add(order);
                    Console.WriteLine("Added Item");
                }
                else
                {
                    Console.WriteLine("No Such Item Or item alread added");
                }
                flag = true;

            }
            Console.WriteLine("Items in Cart");
            foreach(var i in cartItems)
            {
                Console.WriteLine(i.menuItemName);
            }
        }
    }
}
