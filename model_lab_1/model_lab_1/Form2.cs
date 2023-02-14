using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class Form2 : Form
    {
        // Текущая введенная строка
        private string InputLine = "";
        private Dictionary<string, double> ValueMap = new Dictionary<string, double>();

        public Form2()
        {
            InitializeComponent();
            infixText.Text = InputLine;
        }

        // Обработчик нажатия по кнопкам добавления символов (переменных, знаков операций, функций)
        private void Symbol_Click(object sender, EventArgs e)
        {
            // к строке добавляется текст с кнопки, к-ая вызвала событие
            string newSmbl = (sender as Button).Text;
            InputLine += newSmbl;

            // если нажата кнопка с функцией, то добавлятся символ "("
            if (newSmbl == "sin" || newSmbl == "cos" || newSmbl == "tg" || newSmbl == "abs")
                InputLine += "(";

            infixText.Text = InputLine;
        }
    }
}
