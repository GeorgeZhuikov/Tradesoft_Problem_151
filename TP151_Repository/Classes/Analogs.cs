using System.Linq;

namespace TP151_Repository.Classes
{
    partial class Repository
    {
        /// <summary>
        /// Аналоги
        /// </summary>
        public static IQueryable<Analog> Analogs { get { return DC.Analogs; } }

        public static bool CreateAnalog(Analog analog)
        {
            if (analog.ID == 0)
            {
                DC.Analogs.InsertOnSubmit(analog);
                DC.Analogs.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateAnalog(Analog analog)
        {
            var cache = DC.Analogs.FirstOrDefault(x => x.ID == analog.ID);
            if (cache != null)
            {
                cache.OriginalGoodslD = analog.OriginalGoodslD;
                cache.AnalogGoodsID = analog.AnalogGoodsID;
                cache.Reliance = analog.Reliance;
                DC.Analogs.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool RemoveAnalog(int id)
        {
            var cache = DC.Analogs.FirstOrDefault(x => x.ID == id);
            if (cache != null)
            {
                DC.Analogs.DeleteOnSubmit(cache);
                DC.Analogs.Context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
