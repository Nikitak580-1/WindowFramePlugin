namespace WindowFramePlugin
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using WindowFramePlugin.Model;
    using WindowFramePlugin.Wrapper;

    /// <summary>
    /// MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Параметры рамы окна.
        /// </summary>
        private readonly WindowFrameParameters _parameters;

        /// <summary>
        /// Содержит TextBox и соответствующий тип параметра.
        /// </summary>
        private readonly Dictionary<TextBox, ParameterType> _textBoxesDictionary;

        /// <summary>
        /// Содержит TextBox и соответствующий текст ошибки.
        /// </summary>
        private readonly Dictionary<TextBox, string> _textBoxError;

        /// <summary>//
        /// Цвет поля в нормальном состоянии.
        /// </summary>
        private readonly Color _defaultBackColor = Color.White;

        /// <summary>
        /// Цвет поля при ошибке.
        /// </summary>
        private readonly Color _errorBackColor = Color.LightCoral;

        /// <summary>
        /// Содержит методы для работы с главной формой.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _parameters = new WindowFrameParameters();
            _textBoxesDictionary = new Dictionary<TextBox, ParameterType>()
            {
                { W1TextBox, ParameterType.WindowFrameLenghtW1 },
                { H2TextBox, ParameterType.WindowFrameHeightH2 },
                { ThTextBox, ParameterType.TotalWidthWindowFrameTh },
                { TmTextBox, ParameterType.TotalWidthWindowSashesTm },
                { G2TextBox, ParameterType.TotalHeightWindowSashG2 },
                { L3TextBox, ParameterType.LengthPartitionWindowFrameL3 }
            };
            _textBoxError = new Dictionary<TextBox, string>()
            {
                { W1TextBox, "" },
                { H2TextBox, "" },
                { ThTextBox, "" },
                { TmTextBox, "" },
                { G2TextBox, "" },
                { L3TextBox, "" }
            };
            W1TextBox.Text =
                _parameters.GetParameterValue(
                    ParameterType.WindowFrameLenghtW1).ToString();
            H2TextBox.Text
                = _parameters.GetParameterValue(
                    ParameterType.WindowFrameHeightH2).ToString();
            ThTextBox.Text
                = _parameters.GetParameterValue(
                    ParameterType.TotalWidthWindowFrameTh).ToString();
            TmTextBox.Text
                = _parameters.GetParameterValue(
                    ParameterType.TotalWidthWindowSashesTm).ToString();
            G2TextBox.Text
                = _parameters.GetParameterValue(
                    ParameterType.TotalHeightWindowSashG2).ToString();
            L3TextBox.Text
                = _parameters.GetParameterValue(
                    ParameterType.LengthPartitionWindowFrameL3).ToString();
        }

        /// <summary>
        /// Построить оконную раму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (W1TextBox.BackColor == _errorBackColor
                || H2TextBox.BackColor == _errorBackColor
                || ThTextBox.BackColor == _errorBackColor
                || TmTextBox.BackColor == _errorBackColor
                || G2TextBox.BackColor == _errorBackColor
                || L3TextBox.BackColor == _errorBackColor)
            {
                if (CheckFormOnErrors())
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var build = new Builder();
                build.BuildWindowFrame(_parameters);
            }
        }

        /// <summary>
        /// Изменить параметры рамы окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetParameters(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(","))
            {
                textBox.Text = textBox.Text.Substring(1);
            }

            if (textBox.Text == "")
            {
                AddErrorTextEmptyTextBox(textBox);
                textBox.BackColor = _errorBackColor;
                return;
            }

            try
            {
                var value = double.Parse(textBox.Text);
                var type = _textBoxesDictionary[textBox];
                _parameters.SetParameterValue(type, value);
                if (type == ParameterType.WindowFrameLenghtW1)
                {
                    RangeG2Label.Text =
                        SetLableRange(ParameterType.TotalHeightWindowSashG2);
                    RangeL3Label.Text =
                        SetLableRange(ParameterType.LengthPartitionWindowFrameL3);
                    TextBoxValidating(G2TextBox);
                    TextBoxValidating(L3TextBox);
                }

                _textBoxError[textBox] = "";
                textBox.BackColor = _defaultBackColor;
            }
            catch (ArgumentException exception)
            {
                textBox.BackColor = _errorBackColor;
                _textBoxError[textBox] = exception.Message;
            }
        }

        /// <summary>
        /// Валидация текстбокса.
        /// </summary>
        /// <param name="textBox"></param>
        private void TextBoxValidating(TextBox textBox)
        {
            try
            {
                var type = _textBoxesDictionary[textBox];
                var value = _parameters.GetParameterValue(type);
                _parameters.SetParameterValue(type, value);
                _textBoxError[textBox] = "";
                textBox.BackColor = _defaultBackColor;
            }
            catch (ArgumentException exception)
            {
                textBox.BackColor = _errorBackColor;
                _textBoxError[textBox] = exception.Message;
            }
        }

        /// <summary>
        /// Изменить отображаемый диапазон.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Текст диапазона допустимых значений.</returns>
        private string SetLableRange(ParameterType type)
        {
            var min = _parameters.GetParameterMinValue(type).ToString();
            var max = _parameters.GetParameterMaxValue(type).ToString();
            var text = $"{min} — {max} мм";
            return text;
        }

        private void AddErrorTextEmptyTextBox(TextBox textBox)
        {
            if (_textBoxesDictionary.ContainsKey(textBox)
                && _textBoxError.ContainsKey(textBox))
            {
                var type = _textBoxesDictionary[textBox];
                switch (type)
                {
                    case ParameterType.WindowFrameLenghtW1:
                    {
                        _textBoxError[textBox] =
                            "Поле длины рамы окна не должно быть пустым";
                        break;
                    }

                    case ParameterType.WindowFrameHeightH2:
                    {
                        _textBoxError[textBox] =
                            "Поле высоты рамы окна не должно быть пустым";
                        break;
                    }

                    case ParameterType.TotalWidthWindowFrameTh:
                    {
                        _textBoxError[textBox] =
                            "Поле общей ширины рамы окна"
                            + " не должно быть пустым";
                        break;
                    }

                    case ParameterType.TotalWidthWindowSashesTm:
                    {
                        _textBoxError[textBox] =
                            "Поле ширины створки и перегородки"
                            + " не должно быть пустым";
                        break;
                    }

                    case ParameterType.TotalHeightWindowSashG2:
                    {
                        _textBoxError[textBox] =
                            "Поле высоты створки не должно быть пустым";
                        break;
                    }

                    case ParameterType.LengthPartitionWindowFrameL3:
                    {
                        _textBoxError[textBox] =
                            "Поле длины перегородки не должно быть пустым";
                        break;
                    }

                    default:
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Запрещает ввод букв и более одной запятой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxLimiter(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            var number = e.KeyChar;

            if (number == ',')
            {
                if (textBox.Text.Contains(",")
                    || (textBox.Text.Length == 0 && number == ','))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Добавление текста ошибки в переменную.
        /// </summary>
        /// <param name="message">переменная с текстом ошибки.</param>
        /// <returns>Текст ошибки.</returns>
        private string AddErrorMessage(string message)
        {
            if (message != string.Empty)
            {
                return message + "\n";
            }

            return string.Empty;
        }

        /// <summary>
        /// Проверка на ошибки в полях формы.
        /// </summary>
        /// <returns>true, если пустой.</returns>
        private bool CheckFormOnErrors()
        {
            var message = "";
            foreach (var error in _textBoxError)
            {
                message += AddErrorMessage(error.Value);
            }

            if (message != string.Empty)
            {
                MessageBox.Show(
                    message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
