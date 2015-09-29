using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Enities
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
       virtual public ICollection<Menu> Menus { get; set; }
       virtual public Table Table { get; set; }
        public int? TableId { get; set; }
        
        }

    }

