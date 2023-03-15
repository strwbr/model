using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace model_lab_1
{
    public partial class MainForm : Form
    {
        private CalculatorForm calculatorForm = new CalculatorForm(); // форма для калькулятора 
        private ArrayList Stack = new ArrayList(); // стек 
        private string InputString; // входная (инфиксная) строка
        private string OutputString; // выходная (постфиксная) строка 

        private byte Pointer = 0; // указатель на вершину стека

        private Point startArrowPos; // начальная позиция указателя вершины стека на форме

        private byte indexOperation = 0; // значение операции в таблице (поведение алгоритма) 

        private CountForm countForm;

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
            // Задание начального положения указателя на форме
            startArrowPos = new Point(arrowLabel.Location.X, arrowLabel.Location.Y);
            // Добавления обработчика события EnterLine
            calculatorForm.EnterLine += CalculatorForm_EnterLine;
            // Отключение кнопок
            beatBtn.Enabled = false;
            translateBtn.Enabled = false;
            calculateBtn.Enabled = false;
            // Добавление строк в таблицу принятия решения и в стек на форме
            decisionTable.Rows.Add(8); // 8 строк в таблице принятия решений
            stackForm.Rows.Add(12); // 12 строк в таблице стека        
            // Выделение верхушки стека
            this.stackForm.ClearSelection();
            this.stackForm.Rows[11].Cells[0].Selected = true;
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
            // Сброс индекса операции
            indexOperation = 0;
            // Включение кнопок
            translateBtn.Enabled = true;
            beatBtn.Enabled = true;
            // Очистка стека и указателя на вершину стека
            Pointer = 0;
            arrowLabel.Location = startArrowPos;
            Stack.Clear();
            ClearStack();
        }

        // Обработчик нажатия на кнопку "Ввести строку"
        private void createBtn_Click(object sender, EventArgs e)
        {
            // Открытие калькулятора
            calculatorForm.ShowDialog();
            postfixText.Text = "";
            OutputString = "";
        }

        // Событие таймера для визуального отображения
        // процесса преобразования в автоматическом режиме
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

        // Метод для получения значения строки в таблице принятия решений
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
                case 'S': row = 7; break; // S = sqrt
                case 'C': row = 7; break; // C = cos
                case 'L': row = 7; break; // L = lg
            }
            return row;
        }

        // Метод для получения значения столбца в таблице принятия решений
        private byte GetColumn(char elem)
        {
            byte col = 0;
            switch (elem)
            {
                case '|': col = 0; break; // Пустая входная строка
                case '+': col = 1; break;
                case '-': col = 2; break;
                case '*': col = 3; break;
                case '/': col = 4; break;
                case '^': col = 5; break;
                case '(': col = 6; break;
                case ')': col = 7; break;
                case 'A': col = 8; break; // A = abs
                case 'S': col = 8; break; // S = sqrt
                case 'C': col = 8; break; // C = cos
                case 'L': col = 8; break; // L = lg
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
                    // 1 - поместить символ из входной строки в стек
                    Operation1(elem);
                    RedrawStack(); // вывод содержимого стека на форму
                    break; // вышесказанное для каждого значения операции 
                case 2:
                    // 2 - извлечь символ из стека и отправить его в выходную строку
                    Operation2();
                    RedrawStack();
                    break;
                case 3:
                    // 3 - удалить символ ")" из входной строки и символ "(" из стека
                    Operation3();
                    RedrawStack();
                    break;
                case 4:
                    // 4 - успешное окончание преобразования
                    MessageBox.Show("Успешное окончание преобразования");
                    createBtn.Enabled = true;
                    calculateBtn.Enabled = true;
                    Stack.Clear(); // Очистка стека
                    break;
                case 5:
                    // 5 - ошибка скобочной структуры
                    MessageBox.Show("Ошибка скобочной структуры!");
                    Stack.Clear();
                    createBtn.Enabled = true;
                    break;
                case 6:
                    // 6 - переслать символ из входной строки в выходную строку
                    Operation6(elem);
                    RedrawStack();
                    break;
                case 7:
                    // 7 - ошибка: после функции отсутствует "("
                    MessageBox.Show("Ошибка: после функции отсутствует '('");
                    Stack.Clear();
                    createBtn.Enabled = true;
                    break;
            }
        }

        // Преобразование входной строки в постфиксную форму
        private void TransformInfixToPostfix()
        {
            // Верхний элемент стека
            // Если стек пустой (т.е. указатель = 0), то элемент равен символу пустого стека '|'
            char currStackElem = (Pointer != 0)
                ? char.Parse(Stack[Pointer - 1].ToString())
                : '|';

            // Текущий символ входной строки
            char currInputStrElem = (InputString.Length != 0)
                ? char.Parse(InputString.Substring(0, 1))
                : '|';

            // Получение индекса операции в таблице принятия решений
            byte col = GetColumn(currInputStrElem);
            byte row = GetRow(currStackElem);
            indexOperation = DijkstraTable[row, col];
            // Выделение ячейки с текущей операцией
            this.decisionTable.Rows[row].Cells[col].Selected = true;

            // Выполнение операции
            DoOperation(indexOperation, currInputStrElem);

            // Вывод входной и выходной строк на форму
            postfixText.Text = OutputString;
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

            // Заполнение стека на форме
            for (byte i = 0; i < Stack.Count; i++)
            {
                stackForm.Rows[stackForm.Rows.Count - 1 - i].Cells[0].Value = Stack[i];
            }

            // Выделение вершины стека
            if (Pointer != 0)
            {
                // Выделение строки - вершины стека в таблице-стеке на форме
                stackForm.Rows[stackForm.RowCount - Pointer].Cells[0].Selected = true;
                // Расчет новой координаты Y для указателя вершины стека на форме
                int newY = startArrowPos.Y - 1 - ((Pointer - 1) * 20);
                arrowLabel.Location = new Point(startArrowPos.X, newY);

            }
        }

        // Метод для очистки стека на форме
        private void ClearStack()
        {
            for (byte i = 0; i < stackForm.Rows.Count; i++)
            {
                stackForm.Rows[i].Cells[0].Value = "";
            }
            stackForm.Rows[stackForm.RowCount - 1].Cells[0].Selected = true;
        }

        // 1 – поместить символ из входной строки в стек
        public void Operation1(char symbol)
        {
            // Если ячейка ранее была использована - перезапись
            if (Stack.Count > Pointer)
            {
                Stack[Pointer] = symbol;
            }
            // Если необходима новая ячейка
            else
            {
                Stack.Add(symbol);
            }
            // Увеличение указателя
            Pointer++;
            // Удаление символа из строки, по которой проходит алгоритм
            InputString = (InputString.Length != 0)
                ? InputString.Substring(1)
                : "";
        }

        // 2 – извлечь символ из стека и отправить его в выходную строку
        public void Operation2()
        {
            // Извлечение элемента из стека в выходную строку
            OutputString += Stack[Pointer - 1];
            Stack[Pointer - 1] = '#'; // Заменяем взятый символ на # - пустоту
                                      //if (Stack.Count != 0) -- откуда это?
            Pointer--;
        }

        // 3 – удалить символ ")" из входной строки и символ "(" из стека
        public void Operation3()
        {
            Stack[Pointer - 1] = '#'; // Заменяем "(" на # - пустоту
            Pointer--;
            // Удаление символа ")" из строки, по которой проходит алгоритм
            InputString = InputString.Substring(InputString.IndexOf(')') + 1);
        }

        // 6 – переслать символ из входной строки в выходную строку
        public void Operation6(char symbol)
        {
            // Добавление символа в выходную строку
            OutputString += symbol;
            InputString = (InputString.Length != 0)
                ? InputString.Substring(1)
                : "";
        }

        // Обработчик нажатия на кнопку "Справка"
        private void infoBtn_Click(object sender, EventArgs e)
        {
            HelpForm Info = new HelpForm(); // форма для вывода справки 
            Info.Show();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            countForm = new CountForm(OutputString);
            countForm.ShowDialog();
            calculateBtn.Enabled = false;
        }
    }
}
