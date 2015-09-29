using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Reservation
    {
        public DateTime DateReservation{get;set;}
        public int Id { get; set; }
        public string Nom { get; set; }
        virtual public ICollection<Menu> Menus { get; set; }
        virtual public Table Table { get; set; }
        //Entier Nullable
        public int? TableId { get; set; }
    }
}
