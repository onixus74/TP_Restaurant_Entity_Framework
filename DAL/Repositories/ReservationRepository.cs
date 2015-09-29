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
            var req = from r in ctx.Reservations
                      group r by r.TableId;
            return req;
        }
        public IEnumerable<Reservation> PlusQue5Menus()
        {
            return ctx.Reservations.Where(r => r.Menus.Count() > 5).ToList();
        }

        public IEnumerable<Reservation> SQLPlusQue5Menus()
        {
            var req = from r in ctx.Reservations
                      where r.Menus.Count() > 5
                      select r;
            return req.ToList();

        }
    }
}
