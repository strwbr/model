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
    public partial class InputValuesForm : Form
    {
        public Dictionary<char, double> operandValues = new Dictionary<char, double>();

        public InputValuesForm(Dictionary<char, double> operandValues)
        {
            InitializeComponent();
            this.operandValues = operandValues;
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            foreach(GroupBox group in inputGroupBox.Controls.OfType<GroupBox>())
            {
                Label label = group.Controls.OfType<Label>().First();
                char ch = Char.Parse(label.Text.Split()[0]);
                if (operandValues.ContainsKey(ch))
                {
                    //падает от комплексных
                    operandValues[ch] = Double.Parse(group.Controls.OfType<TextBox>().First().Text);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
