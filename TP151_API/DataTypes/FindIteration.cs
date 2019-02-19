using System.Collections.Generic;
using TP151_Repository;

namespace TP151_API.DataTypes
{
    /// <summary>
    /// Класс для формирования информации каждого цикла поиска
    /// </summary>
    public class FindIteration
    {
        public int Step { get; set; }
        public List<Analog> Analogs { get; set; }
    }
}
