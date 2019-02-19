using TP151_Repository;

namespace TP151_API.DataTypes
{
    /// <summary>
    /// Класс для формирования информации о маршруте аналогов
    /// </summary>
    public class FindResult
    {
        public int Step { get; set; }
        public Analog Analog { get; set; }
    }
}
