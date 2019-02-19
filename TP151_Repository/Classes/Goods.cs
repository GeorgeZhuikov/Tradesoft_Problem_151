using System.Linq;

namespace TP151_Repository.Classes
{
    partial class Repository
    {
        /// <summary>
        /// Товары
        /// </summary>
        public static IQueryable<Good> Goods { get { return DC.Goods; } }

        public static bool CreateGoods(Good goods)
        {
            if (goods.ID == 0)
            {
                DC.Goods.InsertOnSubmit(goods);
                DC.Goods.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateGoods(Good goods)
        {
            var cache = DC.Goods.FirstOrDefault(x => x.ID == goods.ID);
            if (cache != null)
            {
                cache.VendorCode = goods.VendorCode;
                cache.ProducerID = goods.ProducerID;
                DC.Goods.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveGoods(int id)
        {
            var cache = DC.Goods.FirstOrDefault(x => x.ID == id);
            if (cache != null)
            {
                DC.Goods.DeleteOnSubmit(cache);
                DC.Goods.Context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
