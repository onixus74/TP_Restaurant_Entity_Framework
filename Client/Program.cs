using Dal.Enities;
using Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuRepository mRepo = new MenuRepository();
            Menu m = new Menu { Nom = "3ejja", Prix = 6000 };
            mRepo.AddMenu(m);
            List<Menu> myMenu = mRepo.GetAllMenus() as List<Menu>;
            foreach (var item in myMenu)
            {
                Console.WriteLine(item.Nom + " " + item.Prix);
                Console.ReadKey();

            }
        }
    }
}
