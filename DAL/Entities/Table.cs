using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Table
    {
        public int id { get; set; }
        public bool isAvailable { get; set; }
        public int numero { get; set; }
        virtual public ICollection<Reservation> Reservations { get; set; }
    }
}
