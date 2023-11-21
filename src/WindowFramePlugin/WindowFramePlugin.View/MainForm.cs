using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowFramePlugin.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Цвет, если всё правильно.
        /// </summary>

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildButtonClick(object sender, EventArgs e)
        {

        }

        private void FramelengthTextBox_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(FramelengthTextBox.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка");

                //Возвращаем фокус на поле ввода
                FramelengthTextBox.Focus();
            }
            else if (number < 50 || number > 300)
            {
                MessageBox.Show("Число должно быть в диапазоне от 50 до 300.", "Ошибка");

                //Возвращаем фокус на поле ввода
                FramelengthTextBox.Focus();
            }
        }

        private void FrameHeightTextBox_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(FrameHeightTextBox.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка");

                //Возвращаем фокус на поле ввода
                FrameHeightTextBox.Focus();
            }
            else if (number < 50 || number > 700)
            {
                MessageBox.Show("Число должно быть в диапазоне от 50 до 700.", "Ошибка");

                //Возвращаем фокус на поле ввода
                FrameHeightTextBox.Focus();
            }
        }

        private void FrameWidthTextBox_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(FrameWidthTextBox.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка");

                //Возвращаем фокус на поле ввода
                FrameWidthTextBox.Focus();
            }
            else if (number < 30 || number > 50)
            {
                MessageBox.Show("Число должно быть в диапазоне от 30 до 50.", "Ошибка");

                //Возвращаем фокус на поле ввода
                FrameWidthTextBox.Focus();
            }
        }

        private void WidthOFTheFlapsTextBox_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(WidthOFTheFlapsTextBox.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка");

                //Возвращаем фокус на поле ввода
                WidthOFTheFlapsTextBox.Focus();
            }
            else if (number < 30 || number > 50)
            {
                MessageBox.Show("Число должно быть в диапазоне от 30 до 50.", "Ошибка");

                //Возвращаем фокус на поле ввода
                WidthOFTheFlapsTextBox.Focus();
            }
        }

        private void HeightOFOneLeafTextBox_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(HeightOFOneLeafTextBox.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка");

                //Возвращаем фокус на поле ввода
                HeightOFOneLeafTextBox.Focus();
            }
            else if (number < 45 || number > 700)
            {
                MessageBox.Show("Число должно быть в диапазоне от 45 до 700.", "Ошибка");

                //Возвращаем фокус на поле ввода
                HeightOFOneLeafTextBox.Focus();
            }
        }

        private void HeightOFThreeLeafTextBox_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(HeightOFThreeLeafTextBox.Text, out number))
            {
                MessageBox.Show("Пожалуйста, введите число.", "Ошибка");

                //Возвращаем фокус на поле ввода
                HeightOFThreeLeafTextBox.Focus();
            }
            else if (number < 10 || number > 30)
            {
                MessageBox.Show("Число должно быть в диапазоне от 10 до 30.", "Ошибка");

                //Возвращаем фокус на поле ввода
                HeightOFThreeLeafTextBox.Focus();
            }
        }
    }
}
