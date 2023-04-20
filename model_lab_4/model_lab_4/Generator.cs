using System;

namespace model_lab_4
{
    internal class Generator
    {
        // Максимальное число последовательности
        private const int MAX_NOT_INCLUSIVE = 100;
        // Длина последовательности
        private int seqLength;
        // Частоты появлений конкретных значений СВ f(x)
        public double[] Probability { get; set; }
        // Функция распределения F(x)
        public double[] DistributionFunction { get; set; }
        // Математическое ожидание
        public double MathExpect { get; set; }
        // Дисперсия
        public double Dispersion { get; set; }
        // Начальный x для метода Лемера
        public uint x = 0;

        // Конструктор класса
        public Generator(int seqLength)
        {
            this.seqLength = seqLength;
            Probability = new double[MAX_NOT_INCLUSIVE];
            DistributionFunction = new double[MAX_NOT_INCLUSIVE];
            MathExpect = 0;
            Dispersion = 0;
        }

        // Генерация послежовательности случайных величин с нормальным законом распределения
        public void Generate()
        {
            Probability = new double[MAX_NOT_INCLUSIVE];
            // Генерация целых чисел в диапазоне [0;99] и подсчет кол-ва появлений каждого числа из этого диапазона
            for(int i = 0; i < seqLength; i++)
            {
                Probability[GenerateNumber()]++;
            }
            // Подсчет частоты появления
            Frequency();
            // Вычисление f(x)
            CountDistribution();
            // Вычисление мат. ожидания
            CountMathExpect();
            // Вычисление дисперсии
            CountDispersion();
        }

        // Частота появления каждого числа в диапазоне [0; 99]
        private void Frequency()
        {
            for (int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                Probability[i] /= seqLength;
            }
        }

        // Лемер (интервал [0;1))
        private double Lemer()
        {
            uint a = 1103515245, b = 12345, c = 2147483648;
            x = (a * x + b) % c;
            return (double)x / c;
        }

        // Генерация одного числа из последовательности
        private int GenerateNumber()
        {
            double sum = 0;
            // Вычисление суммы 6 чисел с равномерным законом распределения
            // Конечное число - в интервале [0; 1)
            for(int i = 0; i < 6; i ++)
            {
                sum += Lemer();
                //x *= 65535;
            }
            // Приведение к диапазону [0;99]
            //sum -= 3;
            //sum /= 3;
            //sum += 1;
            //sum *= 50;
            sum /= 6;
            sum *= 100;
            return (int)sum;
        }

        // Расчет F(x)
        private void CountDistribution()
        {
            double sum = 0;
            for (int i = 0; i < MAX_NOT_INCLUSIVE; i++)
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
    }
}
