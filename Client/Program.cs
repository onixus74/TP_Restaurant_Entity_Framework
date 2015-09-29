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
            MenuRepository mrepo = new MenuRepository();
            Menu m = new Menu { Nom = "3ejja", Prix = 6000 };
            mrepo.AddMenu(m);
        }
    }
}
