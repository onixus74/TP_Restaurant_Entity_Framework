using Dal.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    public class MenuRepository
    {
        RestaurantContexte ctx=null;
        public MenuRepository() {
             ctx = new RestaurantContexte();
        }
        public void AddMenu(Menu m) {
            
            ctx.Menus.Add(m);// attach teh entity m with the status of added.
            ctx.SaveChanges();//execute the operations.

        }
        public IEnumerable<Menu> GetAllMenus()
        {
            return ctx.Menus.ToList();
        }
        public Menu GetMenu(int? id)
        {
            return ctx.Menus.Find(id);

        }
        public Menu GetMenu(string name)
        {
            return ctx.Menus.Single(m => m.Nom == name);//expression lamda: passer une fonction comme parametre pour une autre fonction

        }


    }
}
