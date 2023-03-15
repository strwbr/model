namespace model_lab_1
{
    partial class CountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stackForm = new System.Windows.Forms.DataGridView();
            this.stackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.translateBtn = new System.Windows.Forms.Button();
            this.beatBtn = new System.Windows.Forms.Button();
            this.inputBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.originalLine = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.postfixText = new System.Windows.Forms.Label();
            this.resText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.variableValuesBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stackForm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackForm
            // 
            this.stackForm.AllowUserToAddRows = false;
            this.stackForm.AllowUserToDeleteRows = false;
            this.stackForm.AllowUserToResizeColumns = false;
            this.stackForm.AllowUserToResizeRows = false;
            this.stackForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stackForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.stackForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stackForm.ColumnHeadersVisible = false;
            this.stackForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stackColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stackForm.DefaultCellStyle = dataGridViewCellStyle7;
            this.stackForm.Enabled = false;
            this.stackForm.Location = new System.Drawing.Point(401, 328);
            this.stackForm.Margin = new System.Windows.Forms.Padding(4);
            this.stackForm.MultiSelect = false;
            this.stackForm.Name = "stackForm";
            this.stackForm.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stackForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.stackForm.RowHeadersVisible = false;
            this.stackForm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.stackForm.RowTemplate.Height = 20;
            this.stackForm.Size = new System.Drawing.Size(137, 300);
            this.stackForm.TabIndex = 6;
            // 
            // stackColumn
            // 
            this.stackColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stackColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.stackColumn.HeaderText = "Стек";
            this.stackColumn.MinimumWidth = 8;
            this.stackColumn.Name = "stackColumn";
            this.stackColumn.ReadOnly = true;
            this.stackColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.arrowLabel.Location = new System.Drawing.Point(364, 605);
            this.arrowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(29, 23);
            this.arrowLabel.TabIndex = 13;
            this.arrowLabel.Text = "->";
            this.arrowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateBtn
            // 
            this.translateBtn.AutoSize = true;
            this.translateBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.translateBtn.Location = new System.Drawing.Point(765, 328);
            this.translateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(136, 38);
            this.translateBtn.TabIndex = 24;
            this.translateBtn.Text = "Перевести";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // beatBtn
            // 
            this.beatBtn.AutoSize = true;
            this.beatBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.beatBtn.Location = new System.Drawing.Point(765, 386);
            this.beatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beatBtn.Name = "beatBtn";
            this.beatBtn.Size = new System.Drawing.Size(136, 38);
            this.beatBtn.TabIndex = 23;
            this.beatBtn.Text = "Такт";
            this.beatBtn.UseVisualStyleBackColor = true;
            this.beatBtn.Click += new System.EventHandler(this.beatBtn_Click);
            // 
            // inputBtn
            // 
            this.inputBtn.AutoSize = true;
            this.inputBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputBtn.Location = new System.Drawing.Point(907, 64);
            this.inputBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(171, 41);
            this.inputBtn.TabIndex = 22;
            this.inputBtn.Text = "Ввести числа";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Исходная строка в постфиксной форме:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originalLine
            // 
            this.originalLine.AutoSize = true;
            this.originalLine.BackColor = System.Drawing.Color.White;
            this.originalLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalLine.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.originalLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.originalLine.Location = new System.Drawing.Point(427, 9);
            this.originalLine.Name = "originalLine";
            this.originalLine.Size = new System.Drawing.Size(201, 34);
            this.originalLine.TabIndex = 20;
            this.originalLine.Text = "Исходная строка";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.postfixText);
            this.groupBox1.Controls.Add(this.resText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(884, 220);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // postfixText
            // 
            this.postfixText.AutoSize = true;
            this.postfixText.BackColor = System.Drawing.Color.White;
            this.postfixText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postfixText.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.postfixText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.postfixText.Location = new System.Drawing.Point(6, 62);
            this.postfixText.Name = "postfixText";
            this.postfixText.Size = new System.Drawing.Size(345, 34);
            this.postfixText.TabIndex = 10;
            this.postfixText.Text = "Строка в постфиксной форме";
            // 
            // resText
            // 
            this.resText.AutoSize = true;
            this.resText.BackColor = System.Drawing.Color.White;
            this.resText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resText.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.resText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resText.Location = new System.Drawing.Point(7, 157);
            this.resText.Name = "resText";
            this.resText.Size = new System.Drawing.Size(122, 34);
            this.resText.TabIndex = 9;
            this.resText.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Строка в постфиксной форме:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Обозначения чисел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // variableValuesBox
            // 
            this.variableValuesBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variableValuesBox.Location = new System.Drawing.Point(17, 328);
            this.variableValuesBox.Name = "variableValuesBox";
            this.variableValuesBox.Size = new System.Drawing.Size(320, 305);
            this.variableValuesBox.TabIndex = 25;
            this.variableValuesBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.variableValuesBox);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.beatBtn);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originalLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.arrowLabel);
            this.Controls.Add(this.stackForm);
            this.Name = "CountForm";
            this.Text = "CountForm";
            ((System.ComponentModel.ISupportInitialize)(this.stackForm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stackForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn stackColumn;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.Button beatBtn;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label originalLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label postfixText;
        private System.Windows.Forms.Label resText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox variableValuesBox;
        private System.Windows.Forms.Timer timer1;
    }
}