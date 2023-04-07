using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace model_lab_3
{
    public class Generator
    {
        // Системный генератор
        public const int SYSTEM_RANDOM = 0;
        // Генератор, реализующий метод Лемера
        public const int LEMER_RANDOM = 1;
        // Максимальное число (не включительно) диапазона псевдослучайных чисел
        public const int MAX_NOT_INCLUSIVE = 100;
        // Длина последовательности
        private int seqLength; 
        // Частоты появлений конкретных значений СВ f(x)
        public double[] Probability { get; set; }
        // Функция распределения F(x)
        public double[] DistributionFunction { get; set; }
        // Математическое ожижание
        public double MathExpect { get; set; }
        // Дисперсия
        public double Dispersion { get; set; }
        // Начальный x для метода Лемера
        public double x = 0;

        public Generator(int seqLength)
        {
            this.seqLength = seqLength;
            Probability = new double[100];
            DistributionFunction = new double[100];
            MathExpect = 0;
            Dispersion = 0;
        }

        // Генерация последовательности чисел в зависимости от выбранного вида генератора
        public void Generate(int randomType)
        {
            switch (randomType)
            {
                // Системный генератор
                case SYSTEM_RANDOM:
                    GenerateBySystem(); break;
                // Генератор на основе Лемера
                case LEMER_RANDOM:
                    x = 0; // начальное число последовательности
                    GenerateByLemer(); break;
            }
            // Вычисление f(x)
            CountDistribution();
            // Вычисление мат. ожидания
            CountMathExpect();
            // Вычисление дисперсии
            CountDispersion();
        }

        // Расчет F(x)
        private void CountDistribution()
        {
            double sum = 0;
            for(int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                sum += Probability[i];
                DistributionFunction[i] = sum;
            }
        }

        // Расчет дисперсии
        private void CountDispersion()
        {
            for (int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                Dispersion += Math.Pow((i - MathExpect), 2) * Probability[i];
            }
        }

        // Расчет мат. ожидания
        private void CountMathExpect()
        {
            for(int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                MathExpect += i * Probability[i];
            }
        }

        // Генерация на основе системного генератора
        private void GenerateBySystem()
        {
            Probability = new double[MAX_NOT_INCLUSIVE];
            // Инициализация системного генератора
            Random random = new Random();
            // Генерация целых числа в диапазоне [0; 99] и подсчет кол-во появлений каждого сгенерированного числа
            for (int i = 0; i < seqLength; i++)
            {
                Probability[random.Next(MAX_NOT_INCLUSIVE)]++;
            }
            // Подсчет частоты появления
            Frequency();
        }

        // Генерация на основе метода Лемера
        private void GenerateByLemer()
        {
            Probability = new double[MAX_NOT_INCLUSIVE];
           
            for (int i = 0; i < seqLength; i++)
            {
                int index = LemerN(MAX_NOT_INCLUSIVE);
                Probability[index]++;
            }
            // Подсчет частоты появления
            Frequency();
        }

        // Метод Лемера; возвращает целые числа интервала [0, N-1] 
        private int LemerN(int N)
        {
            x = Lemer(x) * (N - 1);
            int index = (int)(x);
            return index;
        }

        // Частота появления каждого числа в диапазоне [0; 99]
        private void Frequency()
        {
            for (int i = 0; i < Probability.Length; i++)
            {
                Probability[i] /= seqLength;
            }
        }

        // Лемер
        private double Lemer(double x)
        {
            double a = 25173, b = 13849, c = 65536;
            return ((a * x + b) % c) / 65535;
        }

        // Расчет числа pi
        public double Pi()
        {
            // Начальное число последовательности
            x = 0; 
            // Кол-во точек, попавших внутрь окружности
            double countCircle = 0;

            /*for (int i = 0; i < seqLength / 2; i++)
            {
                double num1 = Lemer(x);
                double num2 = Lemer(num1);
                x = num2;
                if(Math.Pow(num1, 2) + Math.Pow(num2, 2) < 1)
                {
                    countCircle++;
                }
            }*/

            // Генерация массива псевдослучайных чисел методом Лемера
            int elements = seqLength * 2;
            double[] arr = new double[elements];
            for(int i = 0; i < elements; i++)
            {
                arr[i] = Lemer(x);
                x = arr[i] * 65535;
            }
            // Подсчет кол-ва сгенерированных чисел, попавших в единичную окружность
            for(int i = 0; i < elements-1; i+=2)
            {
                if (Math.Pow(arr[i], 2) + Math.Pow(arr[i + 1], 2) < 1)
                {
                    countCircle++;
                }
            }
            // Вычисление числа pi
            double pi = 4 * countCircle / (double)(seqLength);
            return pi;
        }
    }
}
