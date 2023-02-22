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
    public partial class Form1 : Form
    {
        private Form2 calculatorForm = new Form2();
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
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            beatBtn.Enabled = false;
        }

        private void beatBtn_Click(object sender, EventArgs e)
        {
            translateBtn.Enabled = false;

            char currStackElem = (stack.Count != 0) ? stack.Peek() : '|';
            char currInputStrElem = (InfixSymbols.Length != 0) ? char.Parse(InfixSymbols.Substring(0, 1)) : '|';

            byte col = 0;
            byte row = 0;

            switch(currStackElem) {
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
            
            switch(currInputStrElem) {
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

            indexOperation = DijkstraAlgorithm.DijkstraTable[row, col];
            this.decisionTable.Rows[row].Cells[col].Selected = true;

            switch(indexOperation)
            {
                case 0: // ...
                    break; 
                case 1:
                    Operation1(currInputStrElem);
                    InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
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
                    MessageBox.Show("Это успехххххх");
                    break;
                case 5:// ...
                    MessageBox.Show("Ошибка скобочной структуры!");
                    break;
                case 6:
                    Operation6(currInputStrElem);
                    InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
                    //RedrawStack();
                    break;
                case 7:
                    MessageBox.Show("После функции отсутствует '('");
                    break;
            }
            //RedrawStack();

            //infixText.Text = InfixSymbols.Substring(indexSymbol);
            //indexSymbol++;
            
            //если ) то удалять нельзя
            //раскидать сабстринг по каждому кейсу (в третий точно не надо)
           // if(!InfixSymbols.StartsWith(")") && !oper3) InfixSymbols = (InfixSymbols.Length!=0) ? InfixSymbols.Substring(1) : "";
            
            postfixText.Text = PostfixLine;
            infixText.Text = InfixSymbols;
        }

        private void RedrawStack()
        {
            if (stack.Count != 0)
            {     
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
            }
        }

        // 1 – поместить символ из входной строки в стек
        public void Operation1(char symbol)
        {
            stack.Push(symbol);
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
        } 
    }
}
