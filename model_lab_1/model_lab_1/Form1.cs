using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class Form1 : Form
    {
        private Form2 calculatorForm = new Form2();
        private Form3 Info = new Form3();
        private Stack<char> stack = new Stack<char>();

        //private char[] InfixSymbols;
        private string InfixSymbols;
        private string PostfixLine;

        private byte indexSymbol = 0;
        private byte indexOperation = 0;

        public Form1()
        {
            InitializeComponent();
            calculatorForm.EnterLine += CalculatorForm_EnterLine;

            // Отключение кнопок
            beatBtn.Enabled = false;
            translateBtn.Enabled = false;

            // Создание строк в таблице и в стеке
            decisionTable.Rows.Add(8);
            stackForm.Rows.Add(10); // 10 строк в стеке == 10 строк в таблице решений

            this.stackForm.ClearSelection();
            this.stackForm.Rows[9].Cells[0].Selected = true;

            // Добавление заголовков у строк в таблице решений
            this.decisionTable.Rows[0].HeaderCell.Value = "|";
            this.decisionTable.Rows[1].HeaderCell.Value = "+";
            this.decisionTable.Rows[2].HeaderCell.Value = "-";
            this.decisionTable.Rows[3].HeaderCell.Value = "*";
            this.decisionTable.Rows[4].HeaderCell.Value = "/";
            this.decisionTable.Rows[5].HeaderCell.Value = "^";
            this.decisionTable.Rows[6].HeaderCell.Value = "(";
            this.decisionTable.Rows[7].HeaderCell.Value = "F";

            // Заполнение таблицы решений
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    this.decisionTable.Rows[i].Cells[j].Value = DijkstraAlgorithm.DijkstraTable[i, j];
                }
            }
        }

        private void CalculatorForm_EnterLine(string line, string displayLine)
        {
            infixText.Text = line;
            originalLine.Text = displayLine;
            //InfixSymbols = new char[line.Length];
            InfixSymbols = line;

            translateBtn.Enabled = true;
            beatBtn.Enabled = true;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // calculatorForm = new Form2();
            calculatorForm.ShowDialog();
            postfixText.Text = "";
            PostfixLine = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (indexOperation == 4 || indexOperation == 5 || indexOperation == 7)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            else
                TransformInfixToPostfix();

        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            beatBtn.Enabled = false;
            createBtn.Enabled = false;
            timer1.Start();
        }

        private byte GetRow(char elem)
        {
            byte row = 0;
            switch (elem)
            {
                case '|': row = 0; break;
                case '+': row = 1; break;
                case '-': row = 2; break;
                case '*': row = 3; break;
                case '/': row = 4; break;
                case '^': row = 5; break;
                case '(': row = 6; break;
                case 'A': row = 7; break;
                case 'S': row = 7; break;
                case 'C': row = 7; break;
                case 'T': row = 7; break;
            }
            return row;
        }

        private byte GetColumn(char elem)
        {
            byte col = 0;
            switch (elem)
            {
                case '|': col = 0; break;
                case '+': col = 1; break;
                case '-': col = 2; break;
                case '*': col = 3; break;
                case '/': col = 4; break;
                case '^': col = 5; break;
                case '(': col = 6; break;
                case ')': col = 7; break;
                case 'A': col = 8; break;
                case 'S': col = 8; break;
                case 'C': col = 8; break;
                case 'T': col = 8; break;
                default: col = 9; break;  //стриггерится и на функции          
            }
            return col;
        }

        private void DoOperation(byte operationID, char elem)
        {
            switch (operationID)
            {
                case 0: // ...
                    break;
                case 1:
                    Operation1(elem);
                    //  InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
                    RedrawStack();
                    break;
                case 2:
                    Operation2();
                    RedrawStack();
                    // InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
                    break;
                case 3:
                    Operation3();
                    RedrawStack();
                    break;
                case 4:
                    //больше не еш
                    //МОЖЕТ то что под свитч кейс уронит код!!!!
                    //beatBtn.Enabled = false;
                    MessageBox.Show("Успешное окончание преобразования");
                    createBtn.Enabled = true;
                    break;
                case 5:// ...
                    MessageBox.Show("Ошибка скобочной структуры!");
                    createBtn.Enabled = true;
                    break;
                case 6:
                    Operation6(elem);
                    //     InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
                    RedrawStack();
                    break;
                case 7:
                    MessageBox.Show("Ошибка: после функции отсутствует '('");
                    createBtn.Enabled = true;
                    break;
            }
        }

        private void TransformInfixToPostfix()
        {
            char currStackElem = (stack.Count != 0) ? stack.Peek() : '|';
            char currInputStrElem = (InfixSymbols.Length != 0) ? char.Parse(InfixSymbols.Substring(0, 1)) : '|';

            byte col = GetColumn(currInputStrElem);
            byte row = GetRow(currStackElem);

            indexOperation = DijkstraAlgorithm.DijkstraTable[row, col]; // вернуть сюда!!!
            this.decisionTable.Rows[row].Cells[col].Selected = true;

            DoOperation(indexOperation, currInputStrElem);

            postfixText.Text = PostfixLine;
            infixText.Text = InfixSymbols;
        }

        private void beatBtn_Click(object sender, EventArgs e)
        {
            translateBtn.Enabled = false;
            createBtn.Enabled = false;

            TransformInfixToPostfix();



            //RedrawStack();

            //infixText.Text = InfixSymbols.Substring(indexSymbol);
            //indexSymbol++;

            //если ) то удалять нельзя
            //раскидать сабстринг по каждому кейсу (в третий точно не надо)
            // if(!InfixSymbols.StartsWith(")") && !oper3) InfixSymbols = (InfixSymbols.Length!=0) ? InfixSymbols.Substring(1) : "";


        }

        private void RedrawStack()
        {
            //if (stack.Count != 0)
            //{
            // Очистка стека на форме
            for (byte i = 0; i < stackForm.Rows.Count; i++)
            {
                stackForm.Rows[i].Cells[0].Value = "";
            }

            Stack<char> copy = new Stack<char>(stack);

            // Добавляет новые строки в стек на форме, если необходимо
            // не тестила - мб улетит:)
            if (stack.Count > stackForm.RowCount)
                stackForm.Rows.Add(stack.Count - stackForm.RowCount);

            //надеюсь стек выжил
            // copy = (Stack<char>)copy.Reverse();
            for (byte i = 0; i < stack.Count; i++)
            {
                stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = copy.Pop();
            }

            // Выделение верхушки стека
            if (stack.Count != 0)
                stackForm.Rows[stackForm.RowCount - stack.Count].Cells[0].Selected = true;
            //}
        }

        // 1 – поместить символ из входной строки в стек
        public void Operation1(char symbol)
        {
            stack.Push(symbol);
            InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
        }

        // 2 – извлечь символ из стека и отправить его в выходную строку
        public void Operation2()
        {
            //if (stack.Peek() == '(')

            //    stack.Pop();
            //else
            PostfixLine += stack.Pop();
        }

        // 3 – удалить символ ")" из входной строки и символ "(" из стека
        public void Operation3()
        {
            if (stack.Peek() == '(') // можно и без проверки обойтись
                stack.Pop();

            InfixSymbols = InfixSymbols.Substring(InfixSymbols.IndexOf(')') + 1);

            //PostfixLine += stack.Pop();
        }

        // 6 – переслать символ из входной строки в выходную строку
        public void Operation6(char symbol)
        {
            PostfixLine += symbol;
            InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info.Show();
        }


    }
}
