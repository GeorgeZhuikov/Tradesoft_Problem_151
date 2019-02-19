using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP151_API.Utils;
using TP151_Repository.Classes;

namespace TP151_Tests
{
    /// <summary>
    /// Тесты
    /// </summary>
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// Обычный тест поиска маршрута
        /// </summary>
        [TestMethod]
        public void FindLinkTest()
        {
            Repository.Connect();
            FindLinks fl = new FindLinks("kl", "test", 5);
            Assert.IsTrue(fl.Result);
            if (fl.Result)
                foreach (var ld in fl.LinkDatas)
                    System.Diagnostics.Trace.WriteLine(string.Format("{0} : {1}", ld.Route, ld.Content));
        }
        /// <summary>
        /// Тест на ошибку в поиске маршрута
        /// </summary>
        [TestMethod]
        public void FindLinkErrorTest()
        {
            Repository.Connect();
            FindLinks fl = new FindLinks("kl", "045", 1);
            Assert.IsTrue(!fl.Result);
            System.Diagnostics.Trace.WriteLine(fl.ErrorMessage);
        }
        /// <summary>
        /// Тест на параметр "Доверие" в поиске маршрута
        /// </summary>
        [TestMethod]
        public void FindLinkRelianceTest()
        {
            Repository.Connect();
            FindLinks fl = new FindLinks("kl", "testreliance2", 5);
            Assert.IsTrue(!fl.Result);
            System.Diagnostics.Trace.WriteLine(fl.ErrorMessage);
        }
        /// <summary>
        /// Тест для создания БД
        /// </summary>
        [TestMethod]
        public void CreateDBTest()
        {
            General.CreateDataBase("localhost", "", "");
        }
    }
}
