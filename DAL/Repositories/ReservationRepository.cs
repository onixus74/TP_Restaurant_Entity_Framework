using Dal.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    class ReservationRepository
    {
        RestaurantContexte ctx = null;
        public ReservationRepository()
        {
            ctx = new RestaurantContexte();
        }

        public void AddReservation(String name, int numero, Reservation reservation)
        {
            //if (ctx.Tables.Any(t => (t.numero == numero) && (t.isAvailable == true)) && (ctx.Menus.Any(m => m.Nom == name))
            try
            {
                if (ctx.Tables.Any(t => t.isAvailable == true))
                {
                    ctx.Reservations.Add(reservation);
                    ctx.SaveChanges();
                }
                else
                {
                    throw new Exception("Table non disponible");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IQueryable<IGrouping<int?, Reservation>> GetAllReservationByTable()
        {
            //return ctx.Reservations.GroupByw
            var req = from r in ctx.Reservations
                      group r by r.TableId;
            return req ;
        }
    }
}
