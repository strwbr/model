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

            // Создание строк в таблице и в стеке
            decisionTable.Rows.Add(8);
            stackForm.Rows.Add(10); // 10 строк в стеке == 10 строк в таблице решений

            this.stackForm.ClearSelection();
            
            //stack.Rows[0].Cells[0].Value = "+";
            //stack.Rows[1].Cells[0].Value = ")";
            //stack.Rows[2].Cells[0].Value = "/";
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

        private void CalculatorForm_EnterLine(string line)
        {
            infixText.Text = line;
            //InfixSymbols = new char[line.Length];
            InfixSymbols = line;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
           // calculatorForm = new Form2();
            calculatorForm.ShowDialog();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {

        }

        private void beatBtn_Click(object sender, EventArgs e)
        {
            char currStackElem = (stack.Count != 0) ? stack.Peek() : '|';
            char currInputStrElem = (InfixSymbols.Length != 0) ? char.Parse(InfixSymbols.Substring(0, 1)) : '|';

            byte col = 0;
            byte row = 0;
            bool oper3 = false;

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
                    break;
                case 2:
                    Operation2();
                   // InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
                    break;
                case 3:
                    Operation3();
                    oper3 = true;
                    //PopLastSymbol();
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
                    break;
                case 7:
                    MessageBox.Show("После функции отсутствует '('");
                    break;
            }
            if(stack.Count != 0)
            {
                Stack<char> copy = new Stack<char>(stack);
                //надеюсь стек выжил
                //copy = (Stack<char>)copy.Reverse();
                for(byte i = 0; i < stack.Count; i++)
                {
                    stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = copy.Pop();
                }
            }
            //infixText.Text = InfixSymbols.Substring(indexSymbol);
            //indexSymbol++;
            
            //если ) то удалять нельзя
            //раскидать сабстринг по каждому кейсу (в третий точно не надо)
           // if(!InfixSymbols.StartsWith(")") && !oper3) InfixSymbols = (InfixSymbols.Length!=0) ? InfixSymbols.Substring(1) : "";
            
            postfixText.Text = PostfixLine;
            infixText.Text = InfixSymbols;
        }

        public void Operation1(char symbol)
        {
            stack.Push(symbol);
        }

        public void Operation2()
        {
            //if (stack.Peek() == '(')
            
            //    stack.Pop();
            //else
                PostfixLine += stack.Pop();
        }

        public void Operation3()
        {
            if (stack.Peek() == '(') stack.Pop();
            InfixSymbols = InfixSymbols.Substring(InfixSymbols.IndexOf(')') + 1);
            
            //PostfixLine += stack.Pop();
        }

        public void Operation6(char symbol)
        {
            PostfixLine += symbol;
        }

        /*public void PopLastSymbol()
        {
            //TODO
        }*/

        
    }
}
