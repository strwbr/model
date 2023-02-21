using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class Form2 : Form
    {
        // Отображаемая строка
        private string DisplayInfixLine;
        // Строка в инфиксной форме, где функции заменены на спец.символами
        private string InfixLine;
        private Dictionary<string, double> ValueMap = new Dictionary<string, double>();

        public event Action<string> EnterLine;

        public Form2()
        {
            InitializeComponent();
            DisplayInfixLine = InfixLine = "";
            infixText.Text = DisplayInfixLine;
        }

        private void a_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "a";
            InfixLine += "a";
            infixText.Text = DisplayInfixLine;
        }

        private void b_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "b";
            InfixLine += "b";
            infixText.Text = DisplayInfixLine;
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "c";
            InfixLine += "c";
            infixText.Text = DisplayInfixLine;
        }

        private void d_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "d";
            InfixLine += "d";
            infixText.Text = DisplayInfixLine;
        }

        private void e_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "e";
            InfixLine += "e";
            infixText.Text = DisplayInfixLine;
        }

        private void f_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "f";
            InfixLine += "f";
            infixText.Text = DisplayInfixLine;
        }

        private void g_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "g";
            InfixLine += "g";
            infixText.Text = DisplayInfixLine;
        }

        private void h_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "h";
            InfixLine += "h";
            infixText.Text = DisplayInfixLine;
        }

        private void i_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "i";
            InfixLine += "i";
            infixText.Text = DisplayInfixLine;
        }

        private void j_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "j";
            InfixLine += "j";
            infixText.Text = DisplayInfixLine;
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "/";
            InfixLine += "/";
            infixText.Text = DisplayInfixLine;
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "*";
            InfixLine += "*";
            infixText.Text = DisplayInfixLine;
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "-";
            InfixLine += "-";
            infixText.Text = DisplayInfixLine;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "+";
            InfixLine += "+";
            infixText.Text = DisplayInfixLine;
        }

        private void pow_btn_Click(object sender, EventArgs e)
        {
            //"^("
            DisplayInfixLine += "^";
            InfixLine += "^";
            infixText.Text = DisplayInfixLine;
        }

        private void abs_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "abs(";
            InfixLine += "A("; // abs = A
            infixText.Text = DisplayInfixLine;
        }

        private void sin_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "sin(";
            InfixLine += "S("; // sin = S
            infixText.Text = DisplayInfixLine;

        }

        private void cos_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "cos(";
            InfixLine += "C("; // cos = C
            infixText.Text = DisplayInfixLine;
        }

        private void tg_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "tg(";
            InfixLine += "T("; // tg = T
            infixText.Text = DisplayInfixLine;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += "(";
            InfixLine += "(";
            infixText.Text = DisplayInfixLine;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine += ")";
            InfixLine += ")";
            infixText.Text = DisplayInfixLine;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if(InfixLine!=null)
            {
                EnterLine?.Invoke(InfixLine);
                Close(); // Закрытие формы
            } else
            {
                // Alert 
            }
            
        }

        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine = InfixLine = "";
            infixText.Text = DisplayInfixLine;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            DisplayInfixLine = DisplayInfixLine.Remove(DisplayInfixLine.Length - 1);
            InfixLine = InfixLine.Remove(InfixLine.Length - 1);
            infixText.Text = DisplayInfixLine;
        }

        // Обработчик нажатия по кнопкам добавления символов (переменных, знаков операций, функций)
        //private void Symbol_Click(object sender, EventArgs e)
        //{
        //    // к строке добавляется текст с кнопки, к-ая вызвала событие
        //    string newSmbl = (sender as Button).Text;
        //    InputLine += newSmbl;

        //    // если нажата кнопка с функцией, то добавлятся символ "("
        //    if (newSmbl == "sin" || newSmbl == "cos" || newSmbl == "tg" || newSmbl == "abs")
        //        InputLine += "(";

        //    infixText.Text = InputLine;
        //}
    }
}
