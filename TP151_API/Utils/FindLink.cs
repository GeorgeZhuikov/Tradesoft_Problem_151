using System.Collections.Generic;
using System.Linq;
using TP151_API.DataTypes;
using TP151_Repository;
using TP151_Repository.Classes;

namespace TP151_API.Utils
{
    /// <summary>
    /// Поиск маршрута аналогов
    /// </summary>
    public class FindLinks
    {
        private bool _result;
        private List<FindIteration> _fis; //информация о циклах поиска
        private List<LinkData> _links; //информация о маршрутах и их содержимого
        private Good _originalGoods, _toFindGoods; //имходный и искомый товары
        private Producer _originalProducer, _toFindProducer; //имходный и искомый производители
        private List<Good> _goodsList; //список товаров
        private List<Producer> _producerList; //список производителей
        private string _errorMessage; //сообзение об ощибке

        public string ErrorMessage
        {//возвращаем сообщение об ошибке
            get
            {
                return _errorMessage;
            }
        }
        public bool Result
        {//возвращаем сообщение о результате
            get
            {
                return _result;
            }
        }
        public int TotalSteps
        {//возвращаем сообщение о количестве пройденных шагов
            get
            {
                if (_fis != null && _fis.Count > 0)
                    return _fis[_fis.Count - 1].Step;
                else
                    return 0;
            }
        }
        public List<LinkData> LinkDatas
        {//возвращаем информацию о маршрутах
            get
            {
                return _links;
            }
        }
        public Good ToFind
        {//возвращаем информацию о искомом товаре
            get
            {
                return _toFindGoods;
            }
        }

        public FindLinks(string original, string toFind, int steps)
        {//обрабатываем строки поиска связей
            Find(original, toFind, steps); //ищим аналоги
            if (_result) ProceedResult(); //если маршрут найлен, то обрабатываем результат
        }

        private Good GetGoodsByFindLinkString(string str)
        {
            Good goods = null;
            var parts = str.Split('/');
            if (parts.Length > 1) //если строка состоит из двух частей, то продолжаем поиск
            {
                string vendorCode = General.ClearFindLinkString(parts[0]);
                string producerName = General.ClearFindLinkString(parts[1]);
                var producer = _producerList.FirstOrDefault(x => General.ClearFindLinkString(x.Name).StartsWith(producerName));
                if (producer != null)
                    goods = _goodsList.Where(x => x.ProducerID == producer.ID).FirstOrDefault(x => General.ClearFindLinkString(x.VendorCode).StartsWith(vendorCode));
            }
            return goods;
        }

        private void Find(string original, string toFind, int steps)
        {
            _goodsList = Repository.Goods.ToList();
            _producerList = Repository.Producers.ToList();
            _originalGoods = GetGoodsByFindLinkString(original); //находим исходный товар
            _toFindGoods = GetGoodsByFindLinkString(toFind); //находим искомый товар 
            int currentStep = 0; //устанавливаем начальные праметры
            _result = false;
            _errorMessage = "Исходный или искомый товар не найден."; //устанавливается такая обшибка сразу, чтобы не обрабатывать случай, когда один из товаров не найден
            if (_originalGoods != null && _toFindGoods != null)
            {//если товары найдены, ищем между ними маршрут
                Analog first = Repository.Analogs.FirstOrDefault(x => x.OriginalGoodslD == _originalGoods.ID); //находим первый аналог
                if (first != null)
                { //если он есть, начинаем искать
                    _fis = new List<FindIteration>() //список для запоминания группы аналогов на каждом шаге
                    {
                        new FindIteration()
                        {
                            Step = currentStep++ + 1, //запоминаем первый аналог
                            Analogs = new List<Analog>() { first }
                        }
                    };
                    while (!_result && currentStep < steps)
                    {//по последней записи из списка циклов поиска ищем новую группу аналогов
                        var currentFI = _fis.Last();
                        if (!CheckFindIteration(currentFI, _toFindGoods.ID))
                        {//если искомый товар не был найден, то продолжаем
                            var analogs = GetAnalogs(currentFI.Analogs); //получаем список аналогов по переданному списку аналогов
                            if (analogs.Count > 0)
                                _fis.Add(new FindIteration()
                                {
                                    Step = currentStep++ + 1,
                                    Analogs = analogs
                                });
                            else //если новых аналогов больше нет, то прерываем цикл
                                break;
                        }
                        else
                        { //если искомый товар найден, то помечаем это и очищаем сообщение об ошибке
                            _result = true;
                            _errorMessage = "";
                        }

                    }
                    if (!_result) //если искомый товар не найден, то выводим сообщение об ощибке
                        _errorMessage = string.Format("Искомый товар «{0}» не найден за {1} шагов.", ToFind.VendorCode, TotalSteps);
                }
            }
        }

        private List<Analog> GetAnalogs(List<Analog> analogs)
        {//ищем аналоги по переданному списку аналогов
            List<Analog> newAnalogs = new List<Analog>();
            foreach (var analog in analogs.Where(x => x.Reliance))
                newAnalogs.AddRange(Repository.Analogs.Where(x => x.OriginalGoodslD == analog.AnalogGoodsID).ToList());
            return newAnalogs;
        }

        private bool CheckFindIteration(FindIteration findIteration, int goodsID)
        {//проверяем, найден ли был искомый товар в цикле поиска
            bool check = false;
            foreach (var analog in findIteration.Analogs)
                if (analog.AnalogGoodsID == goodsID)
                    check = true;
            return check;
        }

        private Analog GetLinkAnalog(List<Analog> analogs, int goodsID)
        {//находим нужный аналог (который учавствует в маршруте) из списка
            return analogs.FirstOrDefault(x => x.AnalogGoodsID == goodsID);
        }

        private void ProceedResult()
        {//обрабатываем результат поиска
            _links = new List<LinkData>();
            int goodsID = _toFindGoods.ID;
            _fis.Reverse(); //переворачиваем список и с конца идём по цепочке аналогов
            foreach (var fi in _fis)
            {
                var current = GetLinkAnalog(fi.Analogs, goodsID);
                _links.Add(GetLinkData(current, fi.Step));
                goodsID = current.OriginalGoodslD;
            }
            _links.Reverse(); //переворачиваем список обратно
        }

        private LinkData GetLinkData(Analog analog, int step)
        {//формируем информацию для вывода в таблицу о маршруте
            return new LinkData()
            {
                Route = string.Format("маршрут {0}", step),
                Content = string.Format("{0} -> {1}",
                    DB.GetGoods(analog.OriginalGoodslD).VendorCode,
                    DB.GetGoods(analog.AnalogGoodsID).VendorCode)
            };
        }
    }
}
