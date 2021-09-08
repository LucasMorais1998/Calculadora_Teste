
namespace Calculadora
{
    partial class Frm_Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Calc));
            this.Txt_ValorDigitado = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_CE = new System.Windows.Forms.Button();
            this.Btn_Divisao = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_Multiplicacao = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_Subtracao = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_Adicao = new System.Windows.Forms.Button();
            this.Btn_C = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_Ponto = new System.Windows.Forms.Button();
            this.Btn_Resultado = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Pnl_Display = new System.Windows.Forms.Panel();
            this.Txt_Operacao = new System.Windows.Forms.TextBox();
            this.Btn_Backspace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Pnl_Display.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_ValorDigitado
            // 
            this.Txt_ValorDigitado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Txt_ValorDigitado.BackColor = System.Drawing.SystemColors.Desktop;
            this.Txt_ValorDigitado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ValorDigitado.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorDigitado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_ValorDigitado.Location = new System.Drawing.Point(3, 57);
            this.Txt_ValorDigitado.Name = "Txt_ValorDigitado";
            this.Txt_ValorDigitado.Size = new System.Drawing.Size(258, 57);
            this.Txt_ValorDigitado.TabIndex = 4;
            this.Txt_ValorDigitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Backspace, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_CE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Divisao, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Multiplicacao, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Subtracao, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Adicao, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_C, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Ponto, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Resultado, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btn_0, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 248);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Btn_CE
            // 
            this.Btn_CE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CE.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_CE.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_CE.FlatAppearance.BorderSize = 0;
            this.Btn_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CE.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CE.Location = new System.Drawing.Point(69, 3);
            this.Btn_CE.Name = "Btn_CE";
            this.Btn_CE.Size = new System.Drawing.Size(60, 43);
            this.Btn_CE.TabIndex = 4;
            this.Btn_CE.Text = "CE";
            this.Btn_CE.UseVisualStyleBackColor = false;
            this.Btn_CE.Click += new System.EventHandler(this.Btn_CE_Click);
            // 
            // Btn_Divisao
            // 
            this.Btn_Divisao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Divisao.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Divisao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Divisao.FlatAppearance.BorderSize = 0;
            this.Btn_Divisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Divisao.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_Divisao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Divisao.Location = new System.Drawing.Point(201, 3);
            this.Btn_Divisao.Name = "Btn_Divisao";
            this.Btn_Divisao.Size = new System.Drawing.Size(63, 43);
            this.Btn_Divisao.TabIndex = 6;
            this.Btn_Divisao.Text = "/";
            this.Btn_Divisao.UseVisualStyleBackColor = false;
            this.Btn_Divisao.Click += new System.EventHandler(this.Btn_Divisao_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_7.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_7.FlatAppearance.BorderSize = 0;
            this.Btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_7.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_7.Location = new System.Drawing.Point(3, 52);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(60, 43);
            this.Btn_7.TabIndex = 7;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = false;
            this.Btn_7.Click += new System.EventHandler(this.Btn_7_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_8.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_8.FlatAppearance.BorderSize = 0;
            this.Btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_8.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_8.Location = new System.Drawing.Point(69, 52);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(60, 43);
            this.Btn_8.TabIndex = 8;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = false;
            this.Btn_8.Click += new System.EventHandler(this.Btn_8_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_9.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_9.FlatAppearance.BorderSize = 0;
            this.Btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_9.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_9.Location = new System.Drawing.Point(135, 52);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(60, 43);
            this.Btn_9.TabIndex = 9;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = false;
            this.Btn_9.Click += new System.EventHandler(this.Btn_9_Click);
            // 
            // Btn_Multiplicacao
            // 
            this.Btn_Multiplicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Multiplicacao.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Multiplicacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Multiplicacao.FlatAppearance.BorderSize = 0;
            this.Btn_Multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Multiplicacao.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_Multiplicacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Multiplicacao.Location = new System.Drawing.Point(201, 52);
            this.Btn_Multiplicacao.Name = "Btn_Multiplicacao";
            this.Btn_Multiplicacao.Size = new System.Drawing.Size(63, 43);
            this.Btn_Multiplicacao.TabIndex = 10;
            this.Btn_Multiplicacao.Text = "x";
            this.Btn_Multiplicacao.UseVisualStyleBackColor = false;
            this.Btn_Multiplicacao.Click += new System.EventHandler(this.Btn_Multiplicacao_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_4.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_4.FlatAppearance.BorderSize = 0;
            this.Btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_4.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_4.Location = new System.Drawing.Point(3, 101);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(60, 43);
            this.Btn_4.TabIndex = 11;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = false;
            this.Btn_4.Click += new System.EventHandler(this.Btn_4_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_5.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_5.FlatAppearance.BorderSize = 0;
            this.Btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_5.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_5.Location = new System.Drawing.Point(69, 101);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(60, 43);
            this.Btn_5.TabIndex = 12;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = false;
            this.Btn_5.Click += new System.EventHandler(this.Btn_5_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_6.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_6.FlatAppearance.BorderSize = 0;
            this.Btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_6.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_6.Location = new System.Drawing.Point(135, 101);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(60, 43);
            this.Btn_6.TabIndex = 13;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = false;
            this.Btn_6.Click += new System.EventHandler(this.Btn_6_Click);
            // 
            // Btn_Subtracao
            // 
            this.Btn_Subtracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Subtracao.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Subtracao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Subtracao.FlatAppearance.BorderSize = 0;
            this.Btn_Subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Subtracao.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subtracao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Subtracao.Location = new System.Drawing.Point(201, 101);
            this.Btn_Subtracao.Name = "Btn_Subtracao";
            this.Btn_Subtracao.Size = new System.Drawing.Size(63, 43);
            this.Btn_Subtracao.TabIndex = 14;
            this.Btn_Subtracao.Text = "-";
            this.Btn_Subtracao.UseVisualStyleBackColor = false;
            this.Btn_Subtracao.Click += new System.EventHandler(this.Btn_Subtracao_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_1.FlatAppearance.BorderSize = 0;
            this.Btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_1.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_1.Location = new System.Drawing.Point(3, 150);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(60, 43);
            this.Btn_1.TabIndex = 15;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = false;
            this.Btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_2.FlatAppearance.BorderSize = 0;
            this.Btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_2.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_2.Location = new System.Drawing.Point(69, 150);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(60, 43);
            this.Btn_2.TabIndex = 16;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = false;
            this.Btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // Btn_Adicao
            // 
            this.Btn_Adicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Adicao.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Adicao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Adicao.FlatAppearance.BorderSize = 0;
            this.Btn_Adicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adicao.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Adicao.Location = new System.Drawing.Point(201, 150);
            this.Btn_Adicao.Name = "Btn_Adicao";
            this.Btn_Adicao.Size = new System.Drawing.Size(63, 43);
            this.Btn_Adicao.TabIndex = 18;
            this.Btn_Adicao.Text = "+";
            this.Btn_Adicao.UseVisualStyleBackColor = false;
            this.Btn_Adicao.Click += new System.EventHandler(this.Btn_Adicao_Click);
            // 
            // Btn_C
            // 
            this.Btn_C.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_C.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_C.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_C.FlatAppearance.BorderSize = 0;
            this.Btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_C.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_C.Location = new System.Drawing.Point(135, 3);
            this.Btn_C.Name = "Btn_C";
            this.Btn_C.Size = new System.Drawing.Size(60, 43);
            this.Btn_C.TabIndex = 5;
            this.Btn_C.Text = "C";
            this.Btn_C.UseVisualStyleBackColor = false;
            this.Btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_3.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_3.FlatAppearance.BorderSize = 0;
            this.Btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_3.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_3.Location = new System.Drawing.Point(135, 150);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(60, 43);
            this.Btn_3.TabIndex = 17;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = false;
            this.Btn_3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // Btn_Ponto
            // 
            this.Btn_Ponto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ponto.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Ponto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Ponto.FlatAppearance.BorderSize = 0;
            this.Btn_Ponto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ponto.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_Ponto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ponto.Location = new System.Drawing.Point(135, 199);
            this.Btn_Ponto.Name = "Btn_Ponto";
            this.Btn_Ponto.Size = new System.Drawing.Size(60, 46);
            this.Btn_Ponto.TabIndex = 19;
            this.Btn_Ponto.Text = ".";
            this.Btn_Ponto.UseVisualStyleBackColor = false;
            this.Btn_Ponto.Click += new System.EventHandler(this.Btn_Ponto_Click);
            // 
            // Btn_Resultado
            // 
            this.Btn_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Resultado.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Resultado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Resultado.FlatAppearance.BorderSize = 0;
            this.Btn_Resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Resultado.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_Resultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Resultado.Location = new System.Drawing.Point(201, 199);
            this.Btn_Resultado.Name = "Btn_Resultado";
            this.Btn_Resultado.Size = new System.Drawing.Size(63, 46);
            this.Btn_Resultado.TabIndex = 20;
            this.Btn_Resultado.Text = "=";
            this.Btn_Resultado.UseVisualStyleBackColor = false;
            this.Btn_Resultado.Click += new System.EventHandler(this.Btn_Resultado_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_0.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_0.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_0.FlatAppearance.BorderSize = 0;
            this.Btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_0.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.Btn_0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_0.Location = new System.Drawing.Point(69, 199);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(60, 46);
            this.Btn_0.TabIndex = 21;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = false;
            this.Btn_0.Click += new System.EventHandler(this.Btn_0_Click);
            // 
            // Pnl_Display
            // 
            this.Pnl_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Display.BackColor = System.Drawing.SystemColors.InfoText;
            this.Pnl_Display.Controls.Add(this.Txt_Operacao);
            this.Pnl_Display.Controls.Add(this.Txt_ValorDigitado);
            this.Pnl_Display.Location = new System.Drawing.Point(1, 1);
            this.Pnl_Display.Name = "Pnl_Display";
            this.Pnl_Display.Size = new System.Drawing.Size(264, 117);
            this.Pnl_Display.TabIndex = 5;
            // 
            // Txt_Operacao
            // 
            this.Txt_Operacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Operacao.BackColor = System.Drawing.SystemColors.Desktop;
            this.Txt_Operacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Operacao.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Operacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_Operacao.Location = new System.Drawing.Point(156, 3);
            this.Txt_Operacao.Name = "Txt_Operacao";
            this.Txt_Operacao.Size = new System.Drawing.Size(100, 16);
            this.Txt_Operacao.TabIndex = 6;
            this.Txt_Operacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Backspace
            // 
            this.Btn_Backspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Backspace.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Backspace.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Backspace.FlatAppearance.BorderSize = 0;
            this.Btn_Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Backspace.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Backspace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Backspace.Location = new System.Drawing.Point(3, 3);
            this.Btn_Backspace.Name = "Btn_Backspace";
            this.Btn_Backspace.Size = new System.Drawing.Size(60, 43);
            this.Btn_Backspace.TabIndex = 22;
            this.Btn_Backspace.Text = "<";
            this.Btn_Backspace.UseVisualStyleBackColor = false;
            this.Btn_Backspace.Click += new System.EventHandler(this.Btn_Backspace_Click);
            // 
            // Frm_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(269, 381);
            this.Controls.Add(this.Pnl_Display);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Frm_Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Pnl_Display.ResumeLayout(false);
            this.Pnl_Display.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ValorDigitado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_CE;
        private System.Windows.Forms.Button Btn_Divisao;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_Multiplicacao;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_Subtracao;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_Adicao;
        private System.Windows.Forms.Button Btn_C;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_Ponto;
        private System.Windows.Forms.Button Btn_Resultado;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Panel Pnl_Display;
        private System.Windows.Forms.TextBox Txt_Operacao;
        private System.Windows.Forms.Button Btn_Backspace;
    }
}

