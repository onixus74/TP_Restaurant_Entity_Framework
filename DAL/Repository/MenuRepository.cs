using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MenuRepository
    {
        RestaurantContext ctx = null;

        public MenuRepository()
        {
            ctx = new RestaurantContext();
        }
        public void AddMenu(Menu m)
        {

            //Attach le Menu m au context avec le status Added 
            ctx.Menus.Add(m);

            //Commit a la base donnees 
            ctx.SaveChanges();
        }
        public IEnumerable<Menu> GetAllMenu()
        {
            
            return ctx.Menus.ToList();
        }

        public Menu GetMenu(int? id)
        {
            return ctx.Menus.Find(id);

        }

        public Menu GetMenu(String name)
        {
            return ctx.Menus.Single(m => (m.Nom == name)); // Lambda expression
        }



    }
}
