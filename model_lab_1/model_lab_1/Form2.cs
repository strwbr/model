using System;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class Form2 : Form
    {
        // Строка в инфиксной форме, где функции заменены на спец.символами
        private string InfixLine;
        // Событие ввода строки
        public event Action<string> EnterLine;

        public Form2()
        {
            InitializeComponent();
            InfixLine = "";
            infixText.Text = InfixLine;
        }

        // Проверка, является ли последний символ в строке переменной
        private bool CheckLetter(char ch)
        {
            bool flag = false; // флаг для определения символа как буква (переменная) 
            // Получение последнего символа в строке
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

        // Проверка, является ли последний символ в строке символом математической операции или открывающейся скобкой
        private bool CheckOperationSymbol(char ch)
        {
            bool flag = false; // флаг для определения символа как операция 
            // Получение последнего символа в строке
            char lastSmbl = (InfixLine.Length != 0)
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
                case '(':
                    {
                        flag = true;
                        MessageBox.Show("Ошибка при вводе символа операции!");
                        break;
                    }
            }
            return flag;
        }
        // Обработчик нажатия на кнопку "a"
        private void a_btn_Click(object sender, EventArgs e)
        {
            // Символ добавляется к строке, если предыдущий символ - не переменная
            if (!CheckLetter('a'))
                InfixLine += "a";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "b"
        private void b_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('b'))
                InfixLine += "b";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "c"
        private void c_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('с'))
                InfixLine += "c";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "d"
        private void d_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('d'))
                InfixLine += "d";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "e"
        private void e_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('e'))
                InfixLine += "e";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "f"
        private void f_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('f'))
                InfixLine += "f";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "g"
        private void g_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('g'))
                InfixLine += "g";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "h"
        private void h_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('h'))
                InfixLine += "h";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "i"
        private void i_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('i'))
                InfixLine += "i";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "j"
        private void j_btn_Click(object sender, EventArgs e)
        {
            if (!CheckLetter('j'))
                InfixLine += "j";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "/"
        private void div_btn_Click(object sender, EventArgs e)
        {
            // Символ добавляется к строке, если предыдущий символ - не знак операции
            if (!CheckOperationSymbol('/'))
                InfixLine += "/";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "*"
        private void mult_btn_Click(object sender, EventArgs e)
        {
            if (!CheckOperationSymbol('*'))
                InfixLine += "*";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "-"
        private void sub_btn_Click(object sender, EventArgs e)
        {
            if (!CheckOperationSymbol('-'))
                InfixLine += "-";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "+"
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!CheckOperationSymbol('+'))
                InfixLine += "+";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "^"
        private void pow_btn_Click(object sender, EventArgs e)
        {
            if (!CheckOperationSymbol('^'))
                InfixLine += "^";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "abs"
        private void abs_btn_Click(object sender, EventArgs e)
        {
            InfixLine += "A("; // abs = A
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "sin"
        private void sin_btn_Click(object sender, EventArgs e)
        {
            InfixLine += "S("; // sin = S
            infixText.Text = InfixLine;

        }
        // Обработчик нажатия на кнопку "cos"
        private void cos_btn_Click(object sender, EventArgs e)
        {
            InfixLine += "C("; // cos = C
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "tg"
        private void tg_btn_Click(object sender, EventArgs e)
        {
            InfixLine += "T("; // tg = T
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "("
        private void open_btn_Click(object sender, EventArgs e)
        {
            InfixLine += "(";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "a"
        private void close_btn_Click(object sender, EventArgs e)
        {
            InfixLine += ")";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "Готово"
        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Если была введена строка
            if (InfixLine.Length != 0)
            {
                // Вызов события
                EnterLine?.Invoke(InfixLine);
                Close(); // Закрытие формы
            }
        }
        // Обработчик нажатия на кнопку "С" - очистка всей строки
        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            InfixLine = "";
            infixText.Text = InfixLine;
        }
        // Обработчик нажатия на кнопку "<-" - удаление одного символа
        private void clear_btn_Click(object sender, EventArgs e)
        {
            // Если строка не пуста
            if (InfixLine.Length != 0)
                InfixLine = InfixLine.Remove(InfixLine.Length - 1);
            infixText.Text = InfixLine;
        }
    }
}
