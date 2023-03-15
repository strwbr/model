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
    public partial class ValueForm : Form
    {
        // Словарь значений переменных
        public Dictionary<char, double> operandValues = new Dictionary<char, double>();

        public ValueForm(Dictionary<char, double> operandValues)
        {
            InitializeComponent();
            this.operandValues = operandValues;
        }

        // Обработчик нажатия на кнопку "Подтвердить"
        private void submitBtn_Click(object sender, EventArgs e)
        {

            foreach(Panel panel in inputPanel.Controls.OfType<Panel>())
            {
                // Получение элемента Label
                Label label = panel.Controls.OfType<Label>().First();
                // Получение первого символа - переменной
                char ch = label.Text[0];

                // Если такая переменная есть в словаре
                if (operandValues.ContainsKey(ch))
                {
                    // Добавление значения переменной
                    operandValues[ch] = Double.Parse(panel.Controls.OfType<TextBox>().First().Text);
                }
            }

            //// Для каждого GroupBox с полями для ввода
            //foreach (GroupBox group in inputGroupBox.Controls.OfType<GroupBox>())
            //{
            //    // Получение элемента Label
            //    Label label = group.Controls.OfType<Label>().First();
            //    // Получение первого символа - переменной
            //    char ch = label.Text[0];

            //    // Если такая переменная есть в словаре
            //    if (operandValues.ContainsKey(ch))
            //    {
            //        // Добавление значения переменной
            //        operandValues[ch] = Double.Parse(group.Controls.OfType<TextBox>().First().Text);
            //    }
            //}
        }
    }
}
