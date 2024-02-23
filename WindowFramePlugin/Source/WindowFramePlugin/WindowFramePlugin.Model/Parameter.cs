namespace WindowFramePlugin.Model
{
    using System;

    /// <summary>
    /// Класс параметра.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Значение параметра.
        /// </summary>
        private double _value;

        /// <summary>
        /// Минимальное значение параметра.
        /// </summary>
        private double _minValue;

        /// <summary>
        /// Максимальное значение параметра.
        /// </summary>
        private double _maxValue;

        /// <summary>
        /// Конструктор параметра.
        /// </summary>
        /// <param name="value">Значение параметра.</param>
        /// <param name="minValue">Минимальное значение параметра.</param>
        /// <param name="maxValue">Максимальное значение параметра.</param>
        public Parameter(double value, double minValue, double maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            Value = value;
        }

        /// <summary>
        /// Передаёт или задаёт значение параметра.
        /// </summary>
        public double Value
        {
            get => _value;
            set
            {
                IsRangeOut(value);
                _value = value;
            }
        }

        /// <summary>
        /// Передаёт или задаёт максимальное значение.
        /// </summary>
        public double MaxValue
        {
            get => _maxValue;
            set
            {
                _maxValue = value;
                IsEqual(value);
            }
        }

        /// <summary>
        /// Передаёт или задаёт минимальное значение.
        /// </summary>
        public double MinValue
        {
            get => _minValue;
            set
            {
                _minValue = value;
                IsEqual(value);
            }
        }

        /// <summary>
        /// Принадлежит ли диапазону допустимых значений.
        /// </summary>
        /// <param name="value">Передаваемое значение.</param>
        /// <exception cref="Exception">Если не принадлежит диапазону.
        /// </exception>
        private void IsRangeOut(double value)
        {
            if (value < _minValue || value > _maxValue)
            {
                throw new ArgumentException($"Значение должно быть" +
                                                      $" от {_minValue} до {_maxValue}");
            }
        }

        /// <summary>
        /// Проверяет на равенство минимальное и максимальное значения.
        /// </summary>
        /// <param name="value">Передаваемое значение.</param>
        /// <exception cref="Exception">Если равны.</exception>
        private void IsEqual(double value)
        {
            if (value == _minValue && value == _maxValue)
            {
                throw new ArgumentException("Минимальное и максимальное" +
                                                      " значенияне не должны быть равны");
            }
        }
    }
}