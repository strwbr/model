﻿namespace model_lab_1
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.infixText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.open_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.clear_all_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.pow_btn = new System.Windows.Forms.Button();
            this.a_btn = new System.Windows.Forms.Button();
            this.b_btn = new System.Windows.Forms.Button();
            this.c_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.d_btn = new System.Windows.Forms.Button();
            this.e_btn = new System.Windows.Forms.Button();
            this.f_btn = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.g_btn = new System.Windows.Forms.Button();
            this.h_btn = new System.Windows.Forms.Button();
            this.i_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.j_btn = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.tg_btn = new System.Windows.Forms.Button();
            this.cos_btn = new System.Windows.Forms.Button();
            this.sin_btn = new System.Windows.Forms.Button();
            this.abs_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infixText
            // 
            this.infixText.AutoSize = true;
            this.infixText.BackColor = System.Drawing.Color.White;
            this.infixText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infixText.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.infixText.Location = new System.Drawing.Point(41, 39);
            this.infixText.Name = "infixText";
            this.infixText.Size = new System.Drawing.Size(365, 39);
            this.infixText.TabIndex = 1;
            this.infixText.Text = "Строка в инфиксной форме";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.open_btn);
            this.flowLayoutPanel1.Controls.Add(this.close_btn);
            this.flowLayoutPanel1.Controls.Add(this.clear_all_btn);
            this.flowLayoutPanel1.Controls.Add(this.clear_btn);
            this.flowLayoutPanel1.Controls.Add(this.pow_btn);
            this.flowLayoutPanel1.Controls.Add(this.a_btn);
            this.flowLayoutPanel1.Controls.Add(this.b_btn);
            this.flowLayoutPanel1.Controls.Add(this.c_btn);
            this.flowLayoutPanel1.Controls.Add(this.div_btn);
            this.flowLayoutPanel1.Controls.Add(this.abs_btn);
            this.flowLayoutPanel1.Controls.Add(this.d_btn);
            this.flowLayoutPanel1.Controls.Add(this.e_btn);
            this.flowLayoutPanel1.Controls.Add(this.f_btn);
            this.flowLayoutPanel1.Controls.Add(this.mult_btn);
            this.flowLayoutPanel1.Controls.Add(this.sin_btn);
            this.flowLayoutPanel1.Controls.Add(this.g_btn);
            this.flowLayoutPanel1.Controls.Add(this.h_btn);
            this.flowLayoutPanel1.Controls.Add(this.i_btn);
            this.flowLayoutPanel1.Controls.Add(this.sub_btn);
            this.flowLayoutPanel1.Controls.Add(this.cos_btn);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.j_btn);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.add_btn);
            this.flowLayoutPanel1.Controls.Add(this.tg_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 114);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 354);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // open_btn
            // 
            this.open_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.open_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.open_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.open_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_btn.Location = new System.Drawing.Point(8, 8);
            this.open_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(67, 62);
            this.open_btn.TabIndex = 16;
            this.open_btn.Text = "(";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // close_btn
            // 
            this.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(83, 8);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(67, 62);
            this.close_btn.TabIndex = 18;
            this.close_btn.Text = ")";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // clear_all_btn
            // 
            this.clear_all_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear_all_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear_all_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_all_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_all_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_all_btn.Location = new System.Drawing.Point(158, 8);
            this.clear_all_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear_all_btn.Name = "clear_all_btn";
            this.clear_all_btn.Size = new System.Drawing.Size(67, 62);
            this.clear_all_btn.TabIndex = 17;
            this.clear_all_btn.Text = "C";
            this.clear_all_btn.UseVisualStyleBackColor = false;
            this.clear_all_btn.Click += new System.EventHandler(this.clear_all_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_btn.BackgroundImage")));
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.Location = new System.Drawing.Point(233, 8);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(67, 62);
            this.clear_btn.TabIndex = 0;
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // pow_btn
            // 
            this.pow_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pow_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pow_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.pow_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.pow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pow_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow_btn.Location = new System.Drawing.Point(308, 8);
            this.pow_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pow_btn.Name = "pow_btn";
            this.pow_btn.Size = new System.Drawing.Size(93, 62);
            this.pow_btn.TabIndex = 18;
            this.pow_btn.Text = "^";
            this.pow_btn.UseVisualStyleBackColor = false;
            this.pow_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // a_btn
            // 
            this.a_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.a_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.a_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.a_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.a_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_btn.Location = new System.Drawing.Point(8, 78);
            this.a_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.a_btn.Name = "a_btn";
            this.a_btn.Size = new System.Drawing.Size(67, 62);
            this.a_btn.TabIndex = 19;
            this.a_btn.Text = "a";
            this.a_btn.UseVisualStyleBackColor = false;
            this.a_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // b_btn
            // 
            this.b_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.b_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.b_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_btn.Location = new System.Drawing.Point(83, 78);
            this.b_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_btn.Name = "b_btn";
            this.b_btn.Size = new System.Drawing.Size(67, 62);
            this.b_btn.TabIndex = 1;
            this.b_btn.Text = "b";
            this.b_btn.UseVisualStyleBackColor = false;
            this.b_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // c_btn
            // 
            this.c_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.c_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.c_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.c_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.c_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_btn.Location = new System.Drawing.Point(158, 78);
            this.c_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(67, 62);
            this.c_btn.TabIndex = 2;
            this.c_btn.Text = "c";
            this.c_btn.UseVisualStyleBackColor = false;
            this.c_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // div_btn
            // 
            this.div_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.div_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.div_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.div_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.div_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div_btn.Location = new System.Drawing.Point(233, 78);
            this.div_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(67, 62);
            this.div_btn.TabIndex = 3;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = false;
            this.div_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // d_btn
            // 
            this.d_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.d_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.d_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.d_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.d_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_btn.Location = new System.Drawing.Point(8, 148);
            this.d_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d_btn.Name = "d_btn";
            this.d_btn.Size = new System.Drawing.Size(67, 62);
            this.d_btn.TabIndex = 4;
            this.d_btn.Text = "d";
            this.d_btn.UseVisualStyleBackColor = false;
            this.d_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // e_btn
            // 
            this.e_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.e_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.e_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.e_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.e_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_btn.Location = new System.Drawing.Point(83, 148);
            this.e_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.e_btn.Name = "e_btn";
            this.e_btn.Size = new System.Drawing.Size(67, 62);
            this.e_btn.TabIndex = 5;
            this.e_btn.Text = "e";
            this.e_btn.UseVisualStyleBackColor = false;
            this.e_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // f_btn
            // 
            this.f_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.f_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.f_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.f_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.f_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_btn.Location = new System.Drawing.Point(158, 148);
            this.f_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_btn.Name = "f_btn";
            this.f_btn.Size = new System.Drawing.Size(67, 62);
            this.f_btn.TabIndex = 6;
            this.f_btn.Text = "f";
            this.f_btn.UseVisualStyleBackColor = false;
            this.f_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // mult_btn
            // 
            this.mult_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mult_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mult_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.mult_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.mult_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mult_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult_btn.Location = new System.Drawing.Point(233, 148);
            this.mult_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(67, 62);
            this.mult_btn.TabIndex = 7;
            this.mult_btn.Text = "*";
            this.mult_btn.UseVisualStyleBackColor = false;
            this.mult_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // g_btn
            // 
            this.g_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.g_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.g_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.g_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.g_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.g_btn.Location = new System.Drawing.Point(8, 218);
            this.g_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g_btn.Name = "g_btn";
            this.g_btn.Size = new System.Drawing.Size(67, 62);
            this.g_btn.TabIndex = 8;
            this.g_btn.Text = "g";
            this.g_btn.UseVisualStyleBackColor = false;
            this.g_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // h_btn
            // 
            this.h_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.h_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.h_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.h_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.h_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_btn.Location = new System.Drawing.Point(83, 218);
            this.h_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.h_btn.Name = "h_btn";
            this.h_btn.Size = new System.Drawing.Size(67, 62);
            this.h_btn.TabIndex = 9;
            this.h_btn.Text = "h";
            this.h_btn.UseVisualStyleBackColor = false;
            this.h_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // i_btn
            // 
            this.i_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.i_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.i_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.i_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.i_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_btn.Location = new System.Drawing.Point(158, 218);
            this.i_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.i_btn.Name = "i_btn";
            this.i_btn.Size = new System.Drawing.Size(67, 62);
            this.i_btn.TabIndex = 10;
            this.i_btn.Text = "i";
            this.i_btn.UseVisualStyleBackColor = false;
            this.i_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sub_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sub_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.sub_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.sub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub_btn.Location = new System.Drawing.Point(233, 218);
            this.sub_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(67, 62);
            this.sub_btn.TabIndex = 11;
            this.sub_btn.Text = "-";
            this.sub_btn.UseVisualStyleBackColor = false;
            this.sub_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // button12
            // 
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(8, 288);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 62);
            this.button12.TabIndex = 12;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // j_btn
            // 
            this.j_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.j_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.j_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.j_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.j_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.j_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.j_btn.Location = new System.Drawing.Point(83, 288);
            this.j_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.j_btn.Name = "j_btn";
            this.j_btn.Size = new System.Drawing.Size(67, 62);
            this.j_btn.TabIndex = 13;
            this.j_btn.Text = "j";
            this.j_btn.UseVisualStyleBackColor = false;
            this.j_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // button14
            // 
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(158, 288);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 62);
            this.button14.TabIndex = 14;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(233, 288);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(67, 62);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit_btn.Location = new System.Drawing.Point(34, 475);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(411, 41);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "Готово";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // tg_btn
            // 
            this.tg_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tg_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.tg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.tg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tg_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tg_btn.Location = new System.Drawing.Point(308, 288);
            this.tg_btn.Margin = new System.Windows.Forms.Padding(4);
            this.tg_btn.Name = "tg_btn";
            this.tg_btn.Size = new System.Drawing.Size(93, 62);
            this.tg_btn.TabIndex = 20;
            this.tg_btn.Text = "lg";
            this.tg_btn.UseVisualStyleBackColor = false;
            this.tg_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // cos_btn
            // 
            this.cos_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cos_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cos_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.cos_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.cos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cos_btn.Location = new System.Drawing.Point(308, 218);
            this.cos_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cos_btn.Name = "cos_btn";
            this.cos_btn.Size = new System.Drawing.Size(93, 62);
            this.cos_btn.TabIndex = 17;
            this.cos_btn.Text = "cos";
            this.cos_btn.UseVisualStyleBackColor = false;
            this.cos_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // sin_btn
            // 
            this.sin_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sin_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.sin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.sin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin_btn.Location = new System.Drawing.Point(308, 148);
            this.sin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sin_btn.Name = "sin_btn";
            this.sin_btn.Size = new System.Drawing.Size(93, 62);
            this.sin_btn.TabIndex = 16;
            this.sin_btn.Text = "sqrt";
            this.sin_btn.UseVisualStyleBackColor = false;
            this.sin_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // abs_btn
            // 
            this.abs_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abs_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.abs_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.abs_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.abs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abs_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abs_btn.Location = new System.Drawing.Point(308, 78);
            this.abs_btn.Margin = new System.Windows.Forms.Padding(4);
            this.abs_btn.Name = "abs_btn";
            this.abs_btn.Size = new System.Drawing.Size(93, 62);
            this.abs_btn.TabIndex = 19;
            this.abs_btn.Text = "abs";
            this.abs_btn.UseVisualStyleBackColor = false;
            this.abs_btn.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 554);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.infixText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infixText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button b_btn;
        private System.Windows.Forms.Button c_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button d_btn;
        private System.Windows.Forms.Button e_btn;
        private System.Windows.Forms.Button f_btn;
        private System.Windows.Forms.Button mult_btn;
        private System.Windows.Forms.Button g_btn;
        private System.Windows.Forms.Button h_btn;
        private System.Windows.Forms.Button i_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button j_btn;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button clear_all_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button a_btn;
        private System.Windows.Forms.Button pow_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button abs_btn;
        private System.Windows.Forms.Button sin_btn;
        private System.Windows.Forms.Button cos_btn;
        private System.Windows.Forms.Button tg_btn;
    }
}