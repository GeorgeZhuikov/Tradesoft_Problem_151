namespace TP151_API.Maps
{
    /// <summary>
    /// Класс для вывода информации о товаре в таблицу
    /// </summary>
    public class GoodsMap
    {
        public int ID { get; set; }
        public int Index { get; set; }
        public string VendorCode { get; set; }
        public string Producer { get; set; }
        public string AnalogVendorCode { get; set; }
        public string AnalogProducer { get; set; }
        public int Reliance { get; set; }
    }
}
