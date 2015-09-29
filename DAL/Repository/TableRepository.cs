using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class TableRepository
    {
        RestaurantContext ctx = null;
        public TableRepository()
        {
            ctx = new RestaurantContext();
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
            return ctx.Tables.OfType<TableCouple>();
        }

        public IEnumerable<TableGroupe> Get5TablesGroupe()
        {
            return ctx.Tables.OfType<TableGroupe>().Take(5).ToList();
        }
        public TableCouple GetFirstTableCoupleAvailable(bool chandelle)
        {
            return ctx.Tables.OfType<TableCouple>().First(t => t.DineeChandelle == chandelle && t.isAvailable == true);
        }
    }
}
