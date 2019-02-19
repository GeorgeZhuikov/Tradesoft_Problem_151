using System.Linq;

namespace TP151_Repository.Classes
{
    partial class Repository
    {
        /// <summary>
        /// Производители
        /// </summary>
        public static IQueryable<Producer> Producers { get { return DC.Producers; } }

        public static bool CreateProducer(Producer Producer)
        {
            if (Producer.ID == 0)
            {
                DC.Producers.InsertOnSubmit(Producer);
                DC.Producers.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateProducer(Producer Producer)
        {
            var cache = DC.Producers.FirstOrDefault(x => x.ID == Producer.ID);
            if (cache != null)
            {
                cache.Name = Producer.Name;
                DC.Producers.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveProducer(int id)
        {
            var cache = DC.Producers.FirstOrDefault(x => x.ID == id);
            if (cache != null)
            {
                DC.Producers.DeleteOnSubmit(cache);
                DC.Producers.Context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
