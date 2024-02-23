namespace WindowFramePlugin.Model
{
    /// <summary>
    /// Координаты точки в double.
    /// </summary>
    public class PointDouble
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public PointDouble(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Точка на оси x.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Точка на оси y.
        /// </summary>
        public double Y { get; set; }
    }
}
