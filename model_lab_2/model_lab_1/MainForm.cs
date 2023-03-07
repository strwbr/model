using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class MainForm : Form
    {
        private CalculatorForm calculatorForm = new CalculatorForm(); // форма для калькулятора 
        private HelpForm Info = new HelpForm(); // форма для вывода справки 
        private ArrayList Stack = new ArrayList(); // стек 
        private string InputString; // входная (инфиксная) строка
        private string PostfixLine; // выходная (постфиксная) строка 

        private byte Pointer = 0; // Указатель на вершину стека (по факту кол-во активных символов, типа +,-...)

        private byte indexOperation = 0; // значение операции в таблице (поведение алгоритма) 
        private byte[,] DijkstraTable = new byte[8, 10] // таблица принятия решений 
        {
            { 4, 1, 1, 1, 1, 1, 1, 5, 1, 6 },
            { 2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            { 2, 2, 2, 2, 2, 2, 1, 2, 1, 6 },
            { 5, 1, 1, 1, 1, 1, 1, 3, 1, 6 },
            { 2, 2, 2, 2, 2, 2, 1, 2, 7, 6 }
        };

        public MainForm()
        {
            InitializeComponent();
            calculatorForm.EnterLine += CalculatorForm_EnterLine;
            // Отключение кнопок
            beatBtn.Enabled = false;
            translateBtn.Enabled = false;
            // Создание строк в таблице и в стеке
            decisionTable.Rows.Add(8);
            stackForm.Rows.Add(10); // 10 строк в стеке == 10 строк в таблице решений         
            // Выделение верхушки стека
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
        private void CalculatorForm_EnterLine(string displayLine, string transformLine)
        {
            // Вывод входной строки на форму
            infixText.Text = displayLine;
            originalLine.Text = displayLine;

            InputString = transformLine;

            // Включение кнопок
            translateBtn.Enabled = true;
            beatBtn.Enabled = true;
        }

        // Обработчик нажатия на кнопку "Ввести строку"
        private void createBtn_Click(object sender, EventArgs e)
        {
            // Открытие калькулятора
            calculatorForm.ShowDialog();
            postfixText.Text = "";
            PostfixLine = "";
        }

        // Событие таймера для визуального отображения
        // процесса преобразования в автоматичеком режиме
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Если преобразование завершилось успешно или найдена ошибка
            if (indexOperation == 4 || indexOperation == 5 || indexOperation == 7)
            {
                // Отключение таймера
                timer1.Enabled = false;
                timer1.Stop();
            }
            else
                TransformInfixToPostfix(); // Выполнение преобразования

        }

        // Обработчик нажатия на кнопку "Перевести"
        private void translateBtn_Click(object sender, EventArgs e)
        {
            // Отключение кнопок
            beatBtn.Enabled = false;
            createBtn.Enabled = false;
            // Запуск таймера
            timer1.Start();
        }

        // Метод для получения значения строки в таблице решений
        private byte GetRow(char elem)
        {
            byte row = 0;
            switch (elem)
            {
                case '|': row = 0; break; // Пустой стек
                case '+': row = 1; break;
                case '-': row = 2; break;
                case '*': row = 3; break;
                case '/': row = 4; break;
                case '^': row = 5; break;
                case '(': row = 6; break;
                case 'A': row = 7; break; // A = abs
                case 'S': row = 7; break; // S = sin
                case 'C': row = 7; break; // C = cos
                case 'T': row = 7; break; // T = tg
            }
            return row;
        }

        // Метод для получения значения столбца в таблице решений
        private byte GetColumn(char elem)
        {
            byte col = 0;
            switch (elem)
            {
                case '|': col = 0; break; // Пустая входна строка
                case '+': col = 1; break;
                case '-': col = 2; break;
                case '*': col = 3; break;
                case '/': col = 4; break;
                case '^': col = 5; break;
                case '(': col = 6; break;
                case ')': col = 7; break;
                case 'A': col = 8; break; // A = abs
                case 'S': col = 8; break; // S = sin
                case 'C': col = 8; break; // C = cos
                case 'T': col = 8; break; // T = tg
                default: col = 9; break;  // переменные      
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
                    Stack.Clear(); // Очистка стека
                    break;
                case 5:
                    MessageBox.Show("Ошибка скобочной структуры!");
                    Stack.Clear();
                    createBtn.Enabled = true;
                    break;
                case 6:
                    Operation6(elem);
                    RedrawStack();
                    break;
                case 7:
                    MessageBox.Show("Ошибка: после функции отсутствует '('");
                    Stack.Clear();
                    createBtn.Enabled = true;
                    break;
            }
        }

        // Преобразование входной строки в постфиксную фомру
        private void TransformInfixToPostfix()
        {
            // Верхний элемент стека
            // Если стек пустой, т.е. указатель = 0, то равен символу пустого стека '|'
            char currStackElem = (Pointer!= 0)
                ? char.Parse(Stack[Pointer-1].ToString())
                : '|';

            // Текущий символ входной строки
            char currInputStrElem = (InputString.Length != 0)
                ? char.Parse(InputString.Substring(0, 1))
                : '|';

            // Получение индекса операции
            byte col = GetColumn(currInputStrElem);
            byte row = GetRow(currStackElem);
            indexOperation = DijkstraTable[row, col];
            // Выделение ячейки с текущей операцией
            this.decisionTable.Rows[row].Cells[col].Selected = true;

            // Выполнение операции
            DoOperation(indexOperation, currInputStrElem);

            // Вывод входной и выходной строк на форму
            postfixText.Text = PostfixLine;
            infixText.Text = InputString;
        }

        // Обработчик нажатия на кнопку "Такт"
        private void beatBtn_Click(object sender, EventArgs e)
        {
            // Отключение кнопок
            translateBtn.Enabled = false;
            createBtn.Enabled = false;
            // Выполнение преобразования
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

            // Добавление новых строк в стек на форме, если необходимо
            if (Stack.Count > stackForm.RowCount)
                stackForm.Rows.Add(Stack.Count - stackForm.RowCount);

            //Stack.Reverse();

            // Заполнение стека на форме
            for (byte i = 0; i < Stack.Count; i++)
            {
                stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = Stack[i];
            }

            // Выделение верхушки стека
            if (Pointer != 0)
                stackForm.Rows[stackForm.RowCount - Pointer].Cells[0].Selected = true;
        }

        // 1 – поместить символ из входной строки в стек
        public void Operation1(char symbol)
        {
            if (Stack.Count > Pointer)
            {
                Stack[Pointer] = symbol;
            }
            else
            {
                Stack.Add(symbol);
            }
            Pointer++;
            InputString = (InputString.Length != 0)
                ? InputString.Substring(1)
                : "";
        }

        // 2 – извлечь символ из стека и отправить его в выходную строку
        public void Operation2()
        {
            PostfixLine += Stack[Pointer-1];
            Stack[Pointer - 1] = '#'; // заменяем взятый символ на # - пустоту
            //if (Stack.Count != 0)
                Pointer--;
        }

        // 3 – удалить символ ")" из входной строки и символ "(" из стека
        public void Operation3()
        {
            //if (Stack.Peek() == '(')
            Stack[Pointer-1] = '#'; // заменяем "(" на # - пустоту
            Pointer--; 

            InputString = InputString.Substring(InputString.IndexOf(')') + 1);
        }

        // 6 – переслать символ из входной строки в выходную строку
        public void Operation6(char symbol)
        {
            PostfixLine += symbol;
            InputString = (InputString.Length != 0) 
                ? InputString.Substring(1) 
                : "";
        }

        // Обработчик нажатия на кнопку "Справка"
        private void button1_Click(object sender, EventArgs e)
        {
            Info.Show();
        }
    }
}
