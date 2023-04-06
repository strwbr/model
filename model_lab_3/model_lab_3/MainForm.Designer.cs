namespace model_lab_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.StatField = new System.Windows.Forms.RichTextBox();
            this.InputPiTb = new System.Windows.Forms.TextBox();
            this.InputSeqLenTb = new System.Windows.Forms.TextBox();
            this.CountPiBtn = new System.Windows.Forms.Button();
            this.PiLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneratorTypeGB = new System.Windows.Forms.GroupBox();
            this.LemRb = new System.Windows.Forms.RadioButton();
            this.SysRb = new System.Windows.Forms.RadioButton();
            this.chartProbability = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistributionFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.legendPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GeneratorTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistributionFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StatField);
            this.panel1.Controls.Add(this.InputPiTb);
            this.panel1.Controls.Add(this.InputSeqLenTb);
            this.panel1.Controls.Add(this.CountPiBtn);
            this.panel1.Controls.Add(this.PiLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GeneratorTypeGB);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 614);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статистика";
            // 
            // StatField
            // 
            this.StatField.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatField.Location = new System.Drawing.Point(15, 174);
            this.StatField.Name = "StatField";
            this.StatField.ReadOnly = true;
            this.StatField.Size = new System.Drawing.Size(178, 236);
            this.StatField.TabIndex = 5;
            this.StatField.Text = "";
            // 
            // InputPiTb
            // 
            this.InputPiTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InputPiTb.Location = new System.Drawing.Point(15, 505);
            this.InputPiTb.Name = "InputPiTb";
            this.InputPiTb.Size = new System.Drawing.Size(179, 25);
            this.InputPiTb.TabIndex = 11;
            this.InputPiTb.Text = "100";
            this.InputPiTb.TextChanged += new System.EventHandler(this.InputPiTb_TextChanged);
            // 
            // InputSeqLenTb
            // 
            this.InputSeqLenTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InputSeqLenTb.Location = new System.Drawing.Point(14, 119);
            this.InputSeqLenTb.Name = "InputSeqLenTb";
            this.InputSeqLenTb.Size = new System.Drawing.Size(179, 25);
            this.InputSeqLenTb.TabIndex = 10;
            this.InputSeqLenTb.Text = "100";
            this.InputSeqLenTb.TextChanged += new System.EventHandler(this.InputSeqLenTb_TextChanged);
            // 
            // CountPiBtn
            // 
            this.CountPiBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountPiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountPiBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountPiBtn.Location = new System.Drawing.Point(15, 565);
            this.CountPiBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CountPiBtn.Name = "CountPiBtn";
            this.CountPiBtn.Size = new System.Drawing.Size(178, 32);
            this.CountPiBtn.TabIndex = 9;
            this.CountPiBtn.Text = "Рассчитать";
            this.CountPiBtn.UseVisualStyleBackColor = false;
            this.CountPiBtn.Click += new System.EventHandler(this.CountPiBtn_Click);
            // 
            // PiLbl
            // 
            this.PiLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PiLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiLbl.Location = new System.Drawing.Point(46, 538);
            this.PiLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PiLbl.Name = "PiLbl";
            this.PiLbl.Size = new System.Drawing.Size(147, 19);
            this.PiLbl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 538);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pi = ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(15, 455);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(178, 32);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartBtn.Location = new System.Drawing.Point(15, 416);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(178, 32);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Запуск";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина последовательности";
            // 
            // GeneratorTypeGB
            // 
            this.GeneratorTypeGB.Controls.Add(this.LemRb);
            this.GeneratorTypeGB.Controls.Add(this.SysRb);
            this.GeneratorTypeGB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GeneratorTypeGB.Location = new System.Drawing.Point(14, 6);
            this.GeneratorTypeGB.Margin = new System.Windows.Forms.Padding(2);
            this.GeneratorTypeGB.Name = "GeneratorTypeGB";
            this.GeneratorTypeGB.Padding = new System.Windows.Forms.Padding(2);
            this.GeneratorTypeGB.Size = new System.Drawing.Size(178, 85);
            this.GeneratorTypeGB.TabIndex = 0;
            this.GeneratorTypeGB.TabStop = false;
            this.GeneratorTypeGB.Text = "Генератор";
            // 
            // LemRb
            // 
            this.LemRb.AutoSize = true;
            this.LemRb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LemRb.Location = new System.Drawing.Point(7, 52);
            this.LemRb.Margin = new System.Windows.Forms.Padding(2);
            this.LemRb.Name = "LemRb";
            this.LemRb.Size = new System.Drawing.Size(121, 23);
            this.LemRb.TabIndex = 1;
            this.LemRb.TabStop = true;
            this.LemRb.Text = "Метод Лемера";
            this.LemRb.UseVisualStyleBackColor = true;
            // 
            // SysRb
            // 
            this.SysRb.AutoSize = true;
            this.SysRb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SysRb.Location = new System.Drawing.Point(7, 22);
            this.SysRb.Margin = new System.Windows.Forms.Padding(2);
            this.SysRb.Name = "SysRb";
            this.SysRb.Size = new System.Drawing.Size(104, 23);
            this.SysRb.TabIndex = 0;
            this.SysRb.TabStop = true;
            this.SysRb.Text = "Встроенный";
            this.SysRb.UseVisualStyleBackColor = true;
            // 
            // chartProbability
            // 
            this.chartProbability.BorderlineColor = System.Drawing.Color.Black;
            this.chartProbability.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartProbability.ChartAreas.Add(chartArea1);
            this.chartProbability.Location = new System.Drawing.Point(226, 8);
            this.chartProbability.Name = "chartProbability";
            this.chartProbability.Size = new System.Drawing.Size(659, 304);
            this.chartProbability.TabIndex = 1;
            this.chartProbability.Text = "chart1";
            // 
            // chartDistributionFunc
            // 
            this.chartDistributionFunc.BorderlineColor = System.Drawing.Color.Black;
            this.chartDistributionFunc.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.chartDistributionFunc.ChartAreas.Add(chartArea2);
            this.chartDistributionFunc.Location = new System.Drawing.Point(226, 318);
            this.chartDistributionFunc.Name = "chartDistributionFunc";
            this.chartDistributionFunc.Size = new System.Drawing.Size(659, 304);
            this.chartDistributionFunc.TabIndex = 2;
            this.chartDistributionFunc.Text = "chart2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(230, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "f(x)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(229, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "F(x)";
            // 
            // legendPanel
            // 
            this.legendPanel.Location = new System.Drawing.Point(893, 30);
            this.legendPanel.Margin = new System.Windows.Forms.Padding(0);
            this.legendPanel.Name = "legendPanel";
            this.legendPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.legendPanel.Size = new System.Drawing.Size(115, 590);
            this.legendPanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(890, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Легенда";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1017, 629);
            this.Controls.Add(this.legendPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartDistributionFunc);
            this.Controls.Add(this.chartProbability);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Генераторы псевдослучайных числовых последовательностей | ЛР №3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GeneratorTypeGB.ResumeLayout(false);
            this.GeneratorTypeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistributionFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GeneratorTypeGB;
        private System.Windows.Forms.RadioButton LemRb;
        private System.Windows.Forms.RadioButton SysRb;
        private System.Windows.Forms.Button CountPiBtn;
        private System.Windows.Forms.Label PiLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProbability;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistributionFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputPiTb;
        private System.Windows.Forms.TextBox InputSeqLenTb;
        private System.Windows.Forms.RichTextBox StatField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel legendPanel;
        private System.Windows.Forms.Label label6;
    }
}

