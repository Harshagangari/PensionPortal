using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MenuOrder
{
    public class DisplayMenuItems
    {
       public DisplayMenuItems()
        {
            Console.WriteLine("*-*-*-*-*-* Menu *-*-*-*-*-*");
            Console.WriteLine("ID     Name     Price     Date Of Launch     Is Free To Deliver     Active");
            Console.WriteLine();
            var menuitemlist = new PracticeCheckAzure.Controllers.MenuItemController().Get();
            foreach(var item in menuitemlist)
            {
                Console.WriteLine(item.Id+"    "+item.name+"    "+item.price+"    "+item.dateOfLaunch+"    "+item.freeDelivery+"    "+item.Active);
                Console.WriteLine();
            }
        }
    }
}
