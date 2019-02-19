using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP151_API.Maps;
using TP151_Repository.Classes;

namespace TP151_API.Utils
{
    public static class Fill
    {
        public static List<GoodsMap> Goods()
        {//перебирается список товаров, по каждому товару перебирается список аналогов, каждая запись аналогов добавляется в список для вывода в таблицу
            List<GoodsMap> gms = new List<GoodsMap>();
            foreach (var goods in Repository.Goods.ToList())
            {
                int id = goods.ID;
                string vendorCode = goods.VendorCode;
                string producer = DB.GetProducerName(goods.ProducerID);
                var analogDatas = DB.GetAnalogData(goods.ID);
                if (analogDatas.Count > 0)
                    foreach (var analogData in analogDatas)
                    {
                        gms.Add(new GoodsMap()
                        {
                            ID = id,
                            Index = gms.Count + 1,
                            VendorCode = vendorCode,
                            Producer = producer,
                            AnalogVendorCode = analogData.VandorCode,
                            AnalogProducer = analogData.Producer,
                            Reliance = analogData.Relaince
                        });
                    }
                else
                    gms.Add(new GoodsMap() //если какая-то информация не найдена, то выводятся соответствующие сообщения
                    {
                        ID = id,
                        Index = gms.Count + 1,
                        VendorCode = vendorCode,
                        Producer = producer,
                        AnalogVendorCode = DB.None,
                        AnalogProducer = DB.None,
                        Reliance = DB.NoneReliance
                    });
            }
            return gms;
        }

        public static List<ProducerMap> Producers()
        {//перебирается каждый производитель и добавляется в список для вывода в таблицу
            List<ProducerMap> pms = new List<ProducerMap>();
            foreach (var producer in Repository.Producers.ToList())
                pms.Add(new ProducerMap()
                {
                    ID = producer.ID,
                    Index = pms.Count + 1,
                    Name = producer.Name
                });
            return pms;
        }
    }
}
