using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_lab_3
{
    public class Generator
    {
        public const int SYSTEM_RANDOM = 0;
        public const int LEMER_RANDOM = 1;

        private int seqLength; // Длина последовательности
        public double[] Probability { get; set; }

        public Generator(int seqLength)
        {
            this.seqLength = seqLength;
            Probability = new double[seqLength];
        }

        public void Generate(int randomType)
        {
            switch (randomType)
            {
                case SYSTEM_RANDOM:
                    GenerateBySystem(); break;
                case LEMER_RANDOM:
                    GenerateByLemer(); break;
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

            double x = DateTime.Now.Millisecond; // начальное число последовательности
            for (int i = 0; i < seqLength; i++)
            {
                x = Lemer(x);
                int index = (int)(x * 99 / 65535);
                Probability[index]++;
            }
            Frequency();
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
            int a = 25173, b = 13849, c = 65536;
            return (a * x + b) % c;
        }
    }
}
