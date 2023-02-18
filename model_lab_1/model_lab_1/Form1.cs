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

        private char[] InfixSymbols;
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
            InfixSymbols = new char[line.Length];
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
           // calculatorForm = new Form2();
            calculatorForm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void translateBtn_Click(object sender, EventArgs e)
        {

        }

        private void beatBtn_Click(object sender, EventArgs e)
        {
            char currStackElem = (stack != null)? stack.Peek() : '|';
            char currInputStrElem =(InfixSymbols!=null)? InfixSymbols[indexSymbol]: '|';

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
                case 'F': row = 7; break;            
            }   
            
            switch(currInputStrElem) {
                case '|': col = 0; break;            
                case '+': col = 1; break;            
                case '-': col = 2; break;            
                case '*': col = 3; break;            
                case '/': col = 4; break;            
                case '^': col = 5; break;            
                case '(': col = 6; break;            
                case 'F': col = 7; break;            
                case 'P': col = 8; break;            
            }

            indexOperation = DijkstraAlgorithm.DijkstraTable[row, col];
            this.decisionTable.Rows[row].Cells[col].Selected = true;

            switch(indexOperation)
            {
                case 0: // ...
                    break; 
                case 1:// ...
                    break;
                case 2:// ...
                    break;
                case 3:// ...
                    break;
                case 4:// ...
                    break;
                case 5:// ...
                    break;
                case 6:// ...
                    break;
                case 7:// ...
                    break;
            }

            indexSymbol++;
        }
    }
}
