using System;
using System.Collections.Generic;
using System.Linq;
using TP151_API.DataTypes;
using TP151_Repository;
using TP151_Repository.Classes;

namespace TP151_API.Utils
{
    public static class DB
    {
        public static string None = "Нет в БД"; //сообщение об ошибке, если нет записи в БД
        public static int NoneReliance = -1; //сообщение, если у товара нет аналога
        /// <summary>
        /// Возвращает название производителя
        /// </summary>
        /// <param name="producerID"></param>
        /// <returns></returns>
        public static string GetProducerName(int producerID)
        {
            var producer = GetProducer(producerID);
            string name = (producer == null) ? None : producer.Name;
            return name;
        }
        /// <summary>
        /// Возвращает информацию об аналогах по ID исходного товара
        /// </summary>
        /// <param name="goodsID"></param>
        /// <returns></returns>
        public static List<AnalogData> GetAnalogData(int goodsID)
        {
            var ads = new List<AnalogData>();
            var analogs = Repository.Analogs.Where(x => x.OriginalGoodslD == goodsID).ToList();
            foreach (var analog in Repository.Analogs.Where(x => x.OriginalGoodslD == goodsID).ToList())
            {
                var analogGoods = Repository.Goods.FirstOrDefault(x => x.ID == analog.AnalogGoodsID);
                AnalogData ad = (analogGoods == null) ?
                new AnalogData() { VandorCode = None, Producer = None, Relaince = NoneReliance } :
                new AnalogData()
                {
                    VandorCode = analogGoods.VendorCode,
                    Producer = GetProducerName(analogGoods.ProducerID),
                    Relaince = Convert.ToInt32(analog.Reliance)
                };
                ads.Add(ad);
            }
            return ads;
        }
        /// <summary>
        /// Находит производителя по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Producer GetProducer(int id)
        {
            return Repository.Producers.FirstOrDefault(x => x.ID == id);
        }
        /// <summary>
        /// Возвращает список товаров
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Good GetGoods(int id)
        {
            return Repository.Goods.FirstOrDefault(x => x.ID == id);
        }
        /// <summary>
        /// Возвращает товар с артикулом типа (артикул/производитель)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Good GetGoodsOutput(int id)
        {
            Good goods = Repository.Goods.FirstOrDefault(x => x.ID == id);
            return new Good()
            {
                ID = goods.ID,
                VendorCode = string.Format("{0}/{1}",
                goods.VendorCode,
                GetProducerName(goods.ProducerID))
            };
        }
        /// <summary>
        /// Возвращает список товаров для вывода в combobox (артикул/производитель)
        /// </summary>
        /// <returns></returns>
        public static List<Good> GetGoodsOutputList()
        {
            List<Good> gs = new List<Good>();
            foreach (var goods in Repository.Goods.ToList())
                gs.Add(new Good()
                {
                    ID = goods.ID,
                    VendorCode = string.Format("{0}/{1}",
                    goods.VendorCode, 
                    GetProducerName(goods.ProducerID))
                });
            return gs;
        }
        /// <summary>
        /// Возвращает список производителей
        /// </summary>
        /// <returns></returns>
        public static List<Producer> GetProducers()
        {
            return Repository.Producers.ToList();
        }
        /// <summary>
        /// Удаляет аналоги по ID исходного товара
        /// </summary>
        /// <param name="goodsID"></param>
        public static void RemoveAnalogs(int goodsID)
        {
            foreach (var analog in Repository.Analogs
                .Where(x => x.OriginalGoodslD == goodsID).ToList())
                Repository.RemoveAnalog(analog.ID);
        }
        /// <summary>
        /// Находит аналоги по ID исходного товара
        /// </summary>
        /// <param name="goodsID"></param>
        /// <returns></returns>
        public static List<Analog> GetAnalogs(int goodsID)
        {
            return Repository.Analogs.Where(x => x.OriginalGoodslD == goodsID).ToList();
        }
    }
}
