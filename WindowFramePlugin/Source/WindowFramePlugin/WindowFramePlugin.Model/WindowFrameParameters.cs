namespace WindowFramePlugin.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Класс, хранящий параметры оконной рамы.
    /// </summary>
    public class WindowFrameParameters
    {
        /// <summary>
        /// Хранит тип параметра и его значения.
        /// </summary>
        private readonly Dictionary<ParameterType, Parameter> _parameters;

        /// <summary>
        /// Словарь для диапазонов значений параметров.
        /// </summary>
        private Dictionary<ParameterType, Tuple<double, double>> _rangesValues;

        public WindowFrameParameters()
        {
            GetRangeValues(50);
            _parameters = new Dictionary<ParameterType, Parameter>()
            {
                { ParameterType.WindowFrameLenghtW1, new Parameter(50, 50, 80) },
                { ParameterType.WindowFrameHeightH2, new Parameter(50, 50, 80) },
                { ParameterType.TotalWidthWindowFrameTh, new Parameter(5, 5, 10) },
                { ParameterType.TotalWidthWindowSashesTm, new Parameter(4, 4, 6) },
                { ParameterType.TotalHeightWindowSashG2,
                    new Parameter(
                        5,
                        _rangesValues[ParameterType.TotalHeightWindowSashG2].Item1,
                        _rangesValues[ParameterType.TotalHeightWindowSashG2].Item2) },
                { ParameterType.LengthPartitionWindowFrameL3,
                    new Parameter(
                        5,
                        _rangesValues[ParameterType.LengthPartitionWindowFrameL3].Item1,
                        _rangesValues[ParameterType.LengthPartitionWindowFrameL3].Item2) }
            };
        }

        /// <summary>
        /// Установить значение параметра.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public void SetParameterValue(ParameterType type, double value)
        {
            if (type == ParameterType.WindowFrameLenghtW1)
            {
                CrossValidation(type, value);
                _parameters[type].Value = value;
                GetRangeValues(value);

                _parameters[ParameterType.TotalHeightWindowSashG2].MinValue =
                    _rangesValues[ParameterType.TotalHeightWindowSashG2].Item1;
                _parameters[ParameterType.TotalHeightWindowSashG2].MaxValue =
                    _rangesValues[ParameterType.TotalHeightWindowSashG2].Item2;

                _parameters[ParameterType.LengthPartitionWindowFrameL3].MinValue =
                    _rangesValues[ParameterType.LengthPartitionWindowFrameL3].Item1;
                _parameters[ParameterType.LengthPartitionWindowFrameL3].MaxValue =
                    _rangesValues[ParameterType.LengthPartitionWindowFrameL3].Item2;
            }

            CrossValidation(type, value);
            _parameters[type].Value = value;
        }

        /// <summary>
        /// Возвращает значение параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Значение параметра.</returns>
        public double GetParameterValue(ParameterType type)
        {
            return _parameters[type].Value;
        }

        /// <summary>
        /// Возвращает минимальное значение параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Минимальное значение параметра.</returns>
        public double GetParameterMinValue(ParameterType type)
        {
            return _parameters[type].MinValue;
        }

        /// <summary>
        /// Возвращает максимальное значение параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Максимальное значение параметра.</returns>
        public double GetParameterMaxValue(ParameterType type)
        {
            return _parameters[type].MaxValue;
        }

        private void GetRangeValues(double valueW1)
        {
            _rangesValues = new Dictionary<ParameterType, Tuple<double, double>>
            {
                {
                    ParameterType.TotalHeightWindowSashG2, new Tuple<double, double>(
                        Math.Round(valueW1 * (1d / 10d), 2),
                        Math.Round(valueW1 * (2d / 13d), 2))
                },
                {
                    ParameterType.LengthPartitionWindowFrameL3, new Tuple<double, double>(
                        Math.Round(valueW1 * (1d / 10d), 2),
                        Math.Round(valueW1 * (2d / 13d), 2))
                }
            };
        }

        /// <summary>
        /// Проверка зависимых параметров.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        private void CrossValidation(ParameterType type, double value)
        {
            if (type == ParameterType.WindowFrameLenghtW1)
            {
                if (value < GetParameterMinValue(ParameterType.WindowFrameLenghtW1)
                    || value > GetParameterMaxValue(ParameterType.WindowFrameLenghtW1))
                {
                    throw new ArgumentException(
                        $"Длина рамы окна должна быть в диапазоне между"
                        + $" от {GetParameterMinValue(ParameterType.WindowFrameLenghtW1)}"
                        + $" до {GetParameterMaxValue(ParameterType.WindowFrameLenghtW1)}");
                }
            }

            if (type == ParameterType.WindowFrameHeightH2)
            {
                if (value < GetParameterMinValue(ParameterType.WindowFrameHeightH2)
                    || value > GetParameterMaxValue(ParameterType.WindowFrameHeightH2))
                {
                    throw new ArgumentException(
                        $"Высота рамы окна должна быть в диапазоне между"
                        + $" от {GetParameterMinValue(ParameterType.WindowFrameHeightH2)}"
                        + $" до {GetParameterMaxValue(ParameterType.WindowFrameHeightH2)}");
                }
            }

            if (type == ParameterType.TotalWidthWindowFrameTh)
            {
                if (value < GetParameterMinValue(ParameterType.TotalWidthWindowFrameTh)
                    || value > GetParameterMaxValue(ParameterType.TotalWidthWindowFrameTh))
                {
                    throw new ArgumentException(
                        $"Общая ширина рамы окна должна быть в диапазоне между"
                        + $" от {GetParameterMinValue(ParameterType.TotalWidthWindowFrameTh)}"
                        + $" до {GetParameterMaxValue(ParameterType.TotalWidthWindowFrameTh)}");
                }

                if (value < GetParameterValue(ParameterType.TotalWidthWindowSashesTm))
                {
                    throw new ArgumentException("Общая ширина рамы окна должна быть больше" +
                        " ширины створок и перегородки окна");
                }
            }

            if (type == ParameterType.TotalHeightWindowSashG2)
            {
                if (value > GetParameterValue(ParameterType.WindowFrameHeightH2))
                {
                    throw new ArgumentException(
                        $"Общая высота створки окна по вертикали внутри рамы окна "
                        + $"должна быть меньше или равна"
                        + $" {GetParameterValue(ParameterType.WindowFrameHeightH2)}");
                }

                if (value < GetParameterMinValue(ParameterType.TotalHeightWindowSashG2)
                    || value > GetParameterMaxValue(ParameterType.TotalHeightWindowSashG2))
                {
                    throw new ArgumentException(
                         $"Общая высота створки окна по вертикали внутри рамы окна" +
                         $" должна быть в диапазоне между"
                         + $" от {GetParameterMinValue(ParameterType.TotalHeightWindowSashG2)}"
                         + $" до {GetParameterMaxValue(ParameterType.TotalHeightWindowSashG2)}");
                }
            }

            if (type == ParameterType.LengthPartitionWindowFrameL3)
            {
                if (value < GetParameterMinValue(ParameterType.LengthPartitionWindowFrameL3)
                    || value > GetParameterMaxValue(ParameterType.LengthPartitionWindowFrameL3))
                {
                    throw new ArgumentException(
                         $"Длина перегородки внутри рамы должна быть в диапазоне между"
                         + $" от {GetParameterMinValue(ParameterType.LengthPartitionWindowFrameL3)}"
                         + $" до {GetParameterMaxValue(ParameterType.LengthPartitionWindowFrameL3)}");
                }
            }

            if (type == ParameterType.TotalWidthWindowSashesTm)
            {
                if (value > GetParameterValue(ParameterType.TotalWidthWindowFrameTh))
                {
                    throw new ArgumentException(
                        $"Ширина створок и перегородки окна "
                        + $"должна быть меньше или равна"
                        + $" {GetParameterValue(ParameterType.TotalWidthWindowFrameTh)}");
                }

                if (value < GetParameterMinValue(ParameterType.TotalWidthWindowSashesTm)
                    || value > GetParameterMaxValue(ParameterType.TotalWidthWindowSashesTm))
                {
                    throw new ArgumentException(
                         $"Ширина створок и перегородки окна должна быть в диапазоне между"
                         + $" от {GetParameterMinValue(ParameterType.TotalWidthWindowSashesTm)}"
                         + $" до {GetParameterMaxValue(ParameterType.TotalWidthWindowSashesTm)}");
                }
            }
        }
    }
}
