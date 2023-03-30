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
        public const int SYSTEM_RANDOM = 0;
        public const int LEMER_RANDOM = 1;
        public const int MAX_NOT_INCLUSIVE = 100;

        private int seqLength; // Длина последовательности
        public double[] Probability { get; set; }
        public double[] DistributionFunction { get; set; }

        public double MathExpect { get; set; }
        public double Dispersion { get; set; }

        public double x = 0;

        public Generator(int seqLength)
        {
            this.seqLength = seqLength;
            Probability = new double[100];
            DistributionFunction = new double[100];
            MathExpect = 0;
            Dispersion = 0;
        }

        public void Generate(int randomType)
        {
            switch (randomType)
            {
                case SYSTEM_RANDOM:
                    GenerateBySystem(); break;
                case LEMER_RANDOM:
                    x = 0; // начальное число последовательности
                    GenerateByLemer(); break;
            }
            CountDistribution();
            CountMathExpect();
            CountDispersion();
        }

        private void CountDistribution()
        {
            double sum = 0;
            for(int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                sum += Probability[i];
                DistributionFunction[i] = sum;
            }
        }

        private void CountDispersion()
        {
            for (int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                Dispersion += Math.Pow((i - MathExpect), 2) * Probability[i];
            }
        }

        private void CountMathExpect()
        {
            for(int i = 0; i < MAX_NOT_INCLUSIVE; i++)
            {
                MathExpect += i * Probability[i];
            }
        }

        private void GenerateBySystem()
        {
            Probability = new double[seqLength];

            Random random = new Random();
            // Генерируем целые числа в диапазоне [0; 99] и считаем кол-во появлений каждого сгенеренного числа
            for (int i = 0; i < seqLength; i++)
            {
                Probability[random.Next(seqLength)]++;
            }
            Frequency();
        }

        private void GenerateByLemer()
        {
            Probability = new double[seqLength];
           
            for (int i = 0; i < seqLength; i++)
            {
                int index = LemerN(MAX_NOT_INCLUSIVE);
                Probability[index]++;
            }
            Frequency();
        }

        private int LemerN(int N)
        {
            x = Lemer(x) * (N - 1);
            int index = (int)(x);
            return index;
        }

        // Частота появления
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
            x = 0; // начальное число последовательности
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
            double[] arr = new double[seqLength];
            for(int i = 0; i < seqLength; i++)
            {
                arr[i] = Lemer(x);
                x = arr[i] * 65535;
            }
            for(int i = 0; i < seqLength/2; i++)
            {
                if (Math.Pow(arr[i], 2) + Math.Pow(arr[i + 1], 2) < 1)
                {
                    countCircle++;
                }
            }
            double pi = 4 * countCircle / (double)(seqLength / 2);
            return pi;
        }
    }
}
