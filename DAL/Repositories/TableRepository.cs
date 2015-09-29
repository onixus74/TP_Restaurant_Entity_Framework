using Dal.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    
    class TableRepository
    {
        RestaurantContexte ctx = null;
        public TableRepository() {
            ctx = new RestaurantContexte();
        }
       public void AddTable(Table t)
        {
            ctx.Tables.Add(t);
            ctx.SaveChanges();

        }

      public IEnumerable<Table> GetAllTables()
        {

            return ctx.Tables.OrderBy(t => t.numero).ToList();
        }
      public IEnumerable<TableCouple> GetAllTablesCouple()
        {
            return ctx.Tables.OfType<TableCouple>().ToList();
        }
       public IEnumerable<TableGroupe> Get5TablesGroupe()
        {
            return ctx.Tables.OfType<TableGroupe>().Take(5).ToList();
        }
       public TableCouple GetFirstTableCoupleAvailable(bool chandelle)
        {
            return ctx.Tables.OfType<TableCouple>()
                .First(t => t.DineeChandelle == chandelle && t.isAvailable == true);
        }
       public TableGroupe GetFirstTableGroupeAvailable(int nbPersonne)
        {
            return ctx.Tables.OfType<TableGroupe>().First(t => t.nbChaise >= nbPersonne && t.isAvailable==true);
        }
       public int CountTablesCoupleAvailable()
        {
            return ctx.Tables.OfType<TableCouple>().Where(t => t.isAvailable == true).Count();
        }
       public int CountTablesGroupeAvailable()
        {
            return ctx.Tables.OfType<TableGroupe>().Where(t => t.isAvailable == true).Count();
        }
    }
}
