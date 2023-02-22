using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class Form2 : Form
    {
        // Отображаемая строка
        //private string DisplayInfixLine;
        // Строка в инфиксной форме, где функции заменены на спец.символами
        private string InfixLine;

        public event Action<string, string> EnterLine;

        public Form2()
        {
            InitializeComponent();
            InfixLine = "";
            infixText.Text = InfixLine;
        }

        // вызывать до прибавления к инфикс строке
        private bool CheckLetter(char ch)
        {
            bool flag = false;

            char lastSmbl = (InfixLine.Length != 0)
                ? char.Parse(InfixLine.Substring(InfixLine.Length - 1))
                : '|';
            switch (lastSmbl)
            {
                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                    {
                        flag = true;
                        MessageBox.Show("Нельзя вводить более одной переменной подряд!");
                        break;
                    }
            }
            return flag;
        }

        private bool CheckOperationSymbol(char ch)
        {
            bool flag = false;


            char lastSmbl = (InfixLine.Length!=0) 
                ? char.Parse(InfixLine.Substring(InfixLine.Length - 1))
                : '|';

            switch (lastSmbl)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '^':
                case '|':    
                    {
                        flag = true;
                        MessageBox.Show("Ошибка при вводе символа операции!");
                        break;
                    }
            }
            return flag;
        }

        private void a_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "a";
            if (!CheckLetter('a'))
                InfixLine += "a";
            infixText.Text = InfixLine;
        }

        private void b_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "b";
            if (!CheckLetter('b'))
                InfixLine += "b";
            infixText.Text = InfixLine;
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "c";
            if (!CheckLetter('с')) 
                InfixLine += "c";
            infixText.Text = InfixLine;
        }

        private void d_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "d";
            if (!CheckLetter('d')) 
                InfixLine += "d";
            infixText.Text = InfixLine;
        }

        private void e_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "e";
            if (!CheckLetter('e'))
                InfixLine += "e";
            infixText.Text = InfixLine;
        }

        private void f_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "f";
            if (!CheckLetter('f'))
                InfixLine += "f";
            infixText.Text = InfixLine;
        }

        private void g_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "g";
            if (!CheckLetter('g'))
                InfixLine += "g";
            infixText.Text = InfixLine;
        }

        private void h_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "h";
            if (!CheckLetter('h'))
                InfixLine += "h";
            infixText.Text = InfixLine;
        }

        private void i_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "i";
            if (!CheckLetter('i'))
                InfixLine += "i";
            infixText.Text = InfixLine;
        }

        private void j_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "j";
            if (!CheckLetter('j'))
                InfixLine += "j";
            infixText.Text = InfixLine;
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "/";
            if (!CheckOperationSymbol('/'))
                InfixLine += "/";
            infixText.Text = InfixLine;
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "*";
            if (!CheckOperationSymbol('*'))
                InfixLine += "*";
            infixText.Text = InfixLine;
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "-";
            if (!CheckOperationSymbol('-'))
                InfixLine += "-";
            infixText.Text = InfixLine;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "+";
            if (!CheckOperationSymbol('+'))
                InfixLine += "+";
            infixText.Text = InfixLine;
        }

        private void pow_btn_Click(object sender, EventArgs e)
        {
            //"^("
            //  DisplayInfixLine += "^";
            if (!CheckOperationSymbol('^'))
                InfixLine += "^";
            infixText.Text = InfixLine;
        }

        private void abs_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "abs(";
            InfixLine += "A("; // abs = A
            infixText.Text = InfixLine;
        }

        private void sin_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "sin(";
            InfixLine += "S("; // sin = S
            infixText.Text = InfixLine;

        }

        private void cos_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "cos(";
            InfixLine += "C("; // cos = C
            infixText.Text = InfixLine;
        }

        private void tg_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "tg(";
            InfixLine += "T("; // tg = T
            infixText.Text = InfixLine;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            //  DisplayInfixLine += "(";
            InfixLine += "(";
            infixText.Text = InfixLine;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            // DisplayInfixLine += ")";
            InfixLine += ")";
            infixText.Text = InfixLine;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (InfixLine.Length!=0)
            {
                EnterLine?.Invoke(InfixLine, InfixLine);
                Close(); // Закрытие формы
            }
        }

        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            InfixLine = "";
            infixText.Text = InfixLine;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            // if (DisplayInfixLine.Length!=0)
            //    DisplayInfixLine = DisplayInfixLine.Remove(DisplayInfixLine.Length - 1);
            if (InfixLine.Length != 0)
                InfixLine = InfixLine.Remove(InfixLine.Length - 1);
            infixText.Text = InfixLine;

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
