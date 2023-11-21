using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void FramelengthTextBox_TextChanged(object sender, EventArgs e)
        {
            FramelengthTextBox.LostFocus += new EventHandler(FramelengthTextBox_LostFocus);
        }

        void FramelengthTextBox_LostFocus(object sender, EventArgs e)
        {
            if (FramelengthTextBox.Text.Length == 0) return;
            int x;
            if (int.TryParse(FramelengthTextBox.Text, out x))
            {
                if (x < 50) FramelengthTextBox.Text = "50";
                if (x > 300) FramelengthTextBox.Text = "300";
            }
        }
    }
}
