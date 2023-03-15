using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model_lab_1
{
    internal class Model
    {
        public string PostfixLine { get; set; } // Постфиксная строка
        public ArrayList Stack { get; set; } // Стек
        public Dictionary<char, double> operandValues { get; set; } // Словарь значений переменных
        public int Pointer { get; set; } // Указатель на вершину стека 

        public string ResText { get; set; } // Строка с результатом

        public Model()
        {
            Stack = new ArrayList();
            operandValues = new Dictionary<char, double>();
            Pointer = -1;
            ResText = "";
        }

        // Заполнение словаря значений переменных
        public Dictionary<char, double> FillDictionary()
        {
            foreach (char ch in PostfixLine)
            {
                switch (ch)
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
                        operandValues.Add(ch, 0);
                        break;
                }
            }
            return operandValues;
        }

        // Вычисление выражения
        public int CountExpression()
        {
            // Текущий символ постфиксной строки
            char current = (PostfixLine.Length != 0) ? PostfixLine[0] : '|';
            // Текущий результат вычислений
            double res = 0;
            // Код результата: 0 - без ошибок, 1 - успех, 2 - дел. на 0, 3 - квад. кор., 4 - обл. опр. лог.
            int index = 0; 
            // Удаление символа из строки
            PostfixLine = (PostfixLine.Length != 0)
                ? PostfixLine.Substring(1)
                : "";
            // В зависимости от текущего символа:
            switch (current)
            {
                // Если пустая строка
                case '|':
                    ResText = Stack[Pointer].ToString();
                    //MessageBox.Show("Успешное окончание вычисления!");
                    Pointer--;
                    index = 1;
                    break;
                // Если бинарные операции
                case '-':
                    res = (double)Stack[Pointer - 1] - (double)Stack[Pointer];
                    Stack[Pointer - 1] = res;
                    Pointer--;
                    break;
                case '+':
                    res = (double)Stack[Pointer - 1] + (double)Stack[Pointer];
                    Stack[Pointer - 1] = res;
                    Pointer--;
                    break;
                case '*':
                    res = (double)Stack[Pointer - 1] * (double)Stack[Pointer];
                    Stack[Pointer - 1] = res;
                    Pointer--;
                    break;
                case '^':
                    res = Math.Pow((double)Stack[Pointer - 1], (double)Stack[Pointer]);
                    Stack[Pointer - 1] = res;
                    Pointer--;
                    break;
                case '/':
                    // Если делитель = 0
                    if ((double)Stack[Pointer] == 0)
                    {
                        Pointer = -1;
                        index = 2;
                    }
                    else
                    {
                        res = (double)Stack[Pointer - 1] / (double)Stack[Pointer];
                        Stack[Pointer - 1] = res;
                        Pointer--;
                    }
                    break;
                // Если унарные операции
                case 'S': // Извлечение корня
                    if ((double)Stack[Pointer] < 0)
                    {
                        Pointer = -1;
                        index = 3;
                    }
                    else
                    {
                        res = Math.Sqrt((double)Stack[Pointer]);
                        Stack[Pointer] = res;
                    }
                    break;
                case 'C': // Косинус
                    // Угол в радианах
                    res = Math.Cos((double)Stack[Pointer]);
                    Stack[Pointer] = res;
                    break;
                case 'A': // Модуль
                    res = Math.Abs((double)Stack[Pointer]);
                    Stack[Pointer] = res;
                    break;
                case 'L': //Десятичный логарифм
                    if ((double)Stack[Pointer] <= 0)
                    {
                        Pointer = -1;
                        index = 4;
                    }
                    else
                    {
                        res = Math.Log10((double)Stack[Pointer]);
                        Stack[Pointer] = res;
                    }
                    break;
                    // Если переменные
                default:
                    // Если ячейка ранее была использована - перезапись
                    if (Stack.Count > Pointer + 1)
                    {
                        Stack[Pointer + 1] = operandValues[current];
                    }
                    // Если необходима новая - добавление
                    else
                    {
                        Stack.Add(operandValues[current]);
                    }
                    Pointer++;
                    break;
            }
            return index;
        }
    }
}
