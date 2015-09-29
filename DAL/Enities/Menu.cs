using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Enities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }

        virtual public ICollection <Reservation> Reservations { get; set; }
    }
}
