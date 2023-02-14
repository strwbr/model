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
    public partial class Form1 : Form
    {
        // Таблица принятия решений
        private byte[,] DijkstraTable = new byte[8, 10]
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
            // Создание строк в таблице и в стеке
            decisionTable.Rows.Add(8);
            stack.Rows.Add(10); // 10 строк в стеке == 10 строк в таблице решений

            this.stack.ClearSelection();
            
            stack.Rows[0].Cells[0].Value = "+";
            stack.Rows[1].Cells[0].Value = ")";
            stack.Rows[2].Cells[0].Value = "/";
            this.stack.Rows[9].Cells[0].Selected = true;

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

        private void createBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
