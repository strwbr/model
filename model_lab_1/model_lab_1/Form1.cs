﻿using System;
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
        private Form2 calculatorForm = new Form2(); // форма для калькулятора 
        private Form3 Info = new Form3(); // форма для вывода справки 
        private Stack<char> stack = new Stack<char>(); // стек 


        private string InfixSymbols; //входная строка
        private string PostfixLine; // выходная строка 

        private byte indexSymbol = 0; // индекс очередного символа входной строки
        private byte indexOperation = 0; //значение операции в таблице (поведение алгоритма) 

        public static byte[,] DijkstraTable = new byte[8, 10] // таблица принятия решений 
        {
            { 4, 1, 1, 1, 1, 1, 1, 5, 1, 6 },
            { 2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 2, 2, 2, 1, 2, 1, 6 },
            { 5, 1, 1, 1, 1, 1, 1, 3, 1, 6 },
            { 2, 2, 2, 2, 2, 2, 1, 7, 7, 6 }
        };

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
                    this.decisionTable.Rows[i].Cells[j].Value = DijkstraTable[i, j];
                }
            }
        }

        // Отображение входной строки на калькуляторе 
        private void CalculatorForm_EnterLine(string line, string displayLine)
        {
            infixText.Text = line;
            originalLine.Text = displayLine;
            InfixSymbols = line;

            translateBtn.Enabled = true;
            beatBtn.Enabled = true;
        }

        // Обработчик нажатия на кнопку "Ввести строку"
        private void createBtn_Click(object sender, EventArgs e)
        {
            calculatorForm.ShowDialog();
            postfixText.Text = "";
            PostfixLine = "";
        }

        // Событие таймера для визуального отображения
        // процесса преобразования в автмоатичеком режиме
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

        // Обработчик нажатия на кнопку "Перевести"
        private void translateBtn_Click(object sender, EventArgs e)
        {
            beatBtn.Enabled = false;
            createBtn.Enabled = false;
            timer1.Start();
        }

        // Метод для получения значения строки в таблице решений
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

        // Метод для получения значения столбца в таблице решений
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
                default: col = 9; break;        
            }
            return col;
        }

        // Метод для выполнения операций в зависимости от их значения
        private void DoOperation(byte operationID, char elem)
        {
            switch (operationID)
            {
                case 0: 
                    break;
                case 1:
                    Operation1(elem); // выполнение операции 1
                    RedrawStack(); // вывод содержимого стека на форму
                    break; // вышесказанное для каждого значения операции 
                case 2:
                    Operation2(); 
                    RedrawStack();
                    break;
                case 3:
                    Operation3();
                    RedrawStack();
                    break;
                case 4:
                    MessageBox.Show("Успешное окончание преобразования");
                    createBtn.Enabled = true;
                    break;
                case 5:
                    MessageBox.Show("Ошибка скобочной структуры!");
                    createBtn.Enabled = true;
                    break;
                case 6:
                    Operation6(elem);
                    RedrawStack();
                    break;
                case 7:
                    MessageBox.Show("Ошибка: после функции отсутствует '('");
                    createBtn.Enabled = true;
                    break;
            }
        }

        // Преобразование входной строки в постфиксную фомру
        private void TransformInfixToPostfix()
        {
            char currStackElem = (stack.Count != 0) ? stack.Peek() : '|';
            char currInputStrElem = (InfixSymbols.Length != 0) ? char.Parse(InfixSymbols.Substring(0, 1)) : '|';

            byte col = GetColumn(currInputStrElem);
            byte row = GetRow(currStackElem);

            indexOperation = DijkstraTable[row, col]; 
            this.decisionTable.Rows[row].Cells[col].Selected = true;

            DoOperation(indexOperation, currInputStrElem);

            postfixText.Text = PostfixLine;
            infixText.Text = InfixSymbols;
        }

        // Обработчик нажатия на кнопку "Такт"
        private void beatBtn_Click(object sender, EventArgs e)
        {
            translateBtn.Enabled = false;
            createBtn.Enabled = false;

            TransformInfixToPostfix();
        }

        // Метод для выведения стека на форму
        private void RedrawStack()
        {

            // Очистка стека на форме
            for (byte i = 0; i < stackForm.Rows.Count; i++)
            {
                stackForm.Rows[i].Cells[0].Value = "";
            }

            Stack<char> copy = new Stack<char>(stack);

            // Добавляет новые строки в стек на форме, если необходимо
            if (stack.Count > stackForm.RowCount)
                stackForm.Rows.Add(stack.Count - stackForm.RowCount);

            for (byte i = 0; i < stack.Count; i++)
            {
                stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = copy.Pop();
            }

            // Выделение верхушки стека
            if (stack.Count != 0)
                stackForm.Rows[stackForm.RowCount - stack.Count].Cells[0].Selected = true;
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
            PostfixLine += stack.Pop();
        }

        // 3 – удалить символ ")" из входной строки и символ "(" из стека
        public void Operation3()
        {
            if (stack.Peek() == '(') 
                stack.Pop();

            InfixSymbols = InfixSymbols.Substring(InfixSymbols.IndexOf(')') + 1);

        }

        // 6 – переслать символ из входной строки в выходную строку
        public void Operation6(char symbol)
        {
            PostfixLine += symbol;
            InfixSymbols = (InfixSymbols.Length != 0) ? InfixSymbols.Substring(1) : "";
        }

        // Обработчик нажатия на кнопку "Справка"
        private void button1_Click(object sender, EventArgs e)
        {
            Info.Show();
        }


    }
}
