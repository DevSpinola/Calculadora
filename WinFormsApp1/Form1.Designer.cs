namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botaovirgula = new Button();
            txtresultado = new TextBox();
            botaoC = new Button();
            botaobackspace = new Button();
            botaodivisao = new Button();
            botaoigual = new Button();
            botaoadicao = new Button();
            botaomenos = new Button();
            botaovezes = new Button();
            botaopotencia = new Button();
            botao2 = new Button();
            botao1 = new Button();
            botao3 = new Button();
            botao4 = new Button();
            botao5 = new Button();
            botao8 = new Button();
            botao9 = new Button();
            botao6 = new Button();
            botao7 = new Button();
            botao0 = new Button();
            txtconta = new TextBox();
            SuspendLayout();
            // 
            // botaovirgula
            // 
            botaovirgula.FlatAppearance.BorderSize = 0;
            botaovirgula.FlatStyle = FlatStyle.Flat;
            botaovirgula.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botaovirgula.ForeColor = SystemColors.ButtonFace;
            botaovirgula.Location = new Point(172, 366);
            botaovirgula.Name = "botaovirgula";
            botaovirgula.Size = new Size(54, 58);
            botaovirgula.TabIndex = 41;
            botaovirgula.Text = ",";
            botaovirgula.UseVisualStyleBackColor = true;
            botaovirgula.Click += botaovirgula_Click;
            // 
            // txtresultado
            // 
            txtresultado.BackColor = SystemColors.InactiveCaptionText;
            txtresultado.BorderStyle = BorderStyle.None;
            txtresultado.Font = new Font("Times New Roman", 38.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtresultado.ForeColor = Color.White;
            txtresultado.Location = new Point(12, 26);
            txtresultado.MaxLength = 10;
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(322, 59);
            txtresultado.TabIndex = 40;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            txtresultado.UseWaitCursor = true;
            // 
            // botaoC
            // 
            botaoC.FlatAppearance.BorderSize = 0;
            botaoC.FlatStyle = FlatStyle.Flat;
            botaoC.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            botaoC.ForeColor = Color.FromArgb(192, 64, 0);
            botaoC.Location = new Point(12, 108);
            botaoC.Name = "botaoC";
            botaoC.Size = new Size(54, 58);
            botaoC.TabIndex = 39;
            botaoC.Text = "C";
            botaoC.UseVisualStyleBackColor = true;
            botaoC.Click += botaoC_Click;
            // 
            // botaobackspace
            // 
            botaobackspace.FlatAppearance.BorderSize = 0;
            botaobackspace.FlatStyle = FlatStyle.Flat;
            botaobackspace.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            botaobackspace.ForeColor = Color.FromArgb(192, 64, 0);
            botaobackspace.Location = new Point(72, 104);
            botaobackspace.Name = "botaobackspace";
            botaobackspace.Size = new Size(94, 58);
            botaobackspace.TabIndex = 38;
            botaobackspace.Text = "⍇";
            botaobackspace.UseVisualStyleBackColor = true;
            botaobackspace.Click += botaobackspace_Click;
            // 
            // botaodivisao
            // 
            botaodivisao.FlatAppearance.BorderSize = 0;
            botaodivisao.FlatStyle = FlatStyle.Flat;
            botaodivisao.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            botaodivisao.ForeColor = Color.FromArgb(192, 64, 0);
            botaodivisao.Location = new Point(264, 108);
            botaodivisao.Name = "botaodivisao";
            botaodivisao.Size = new Size(54, 58);
            botaodivisao.TabIndex = 37;
            botaodivisao.Text = "÷";
            botaodivisao.UseVisualStyleBackColor = true;
            botaodivisao.Click += botaodivisao_Click;
            // 
            // botaoigual
            // 
            botaoigual.FlatAppearance.BorderSize = 0;
            botaoigual.FlatStyle = FlatStyle.Flat;
            botaoigual.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            botaoigual.ForeColor = Color.FromArgb(192, 64, 0);
            botaoigual.Location = new Point(264, 367);
            botaoigual.Name = "botaoigual";
            botaoigual.Size = new Size(54, 58);
            botaoigual.TabIndex = 36;
            botaoigual.Text = "=";
            botaoigual.UseVisualStyleBackColor = true;
            botaoigual.Click += botaoigual_Click;
            // 
            // botaoadicao
            // 
            botaoadicao.FlatAppearance.BorderSize = 0;
            botaoadicao.FlatStyle = FlatStyle.Flat;
            botaoadicao.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            botaoadicao.ForeColor = Color.FromArgb(192, 64, 0);
            botaoadicao.Location = new Point(264, 302);
            botaoadicao.Name = "botaoadicao";
            botaoadicao.Size = new Size(54, 58);
            botaoadicao.TabIndex = 35;
            botaoadicao.Text = "+";
            botaoadicao.UseVisualStyleBackColor = true;
            botaoadicao.Click += botaoadicao_Click;
            // 
            // botaomenos
            // 
            botaomenos.FlatAppearance.BorderSize = 0;
            botaomenos.FlatStyle = FlatStyle.Flat;
            botaomenos.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            botaomenos.ForeColor = Color.FromArgb(192, 64, 0);
            botaomenos.Location = new Point(264, 238);
            botaomenos.Name = "botaomenos";
            botaomenos.Size = new Size(54, 58);
            botaomenos.TabIndex = 34;
            botaomenos.Text = "–";
            botaomenos.UseVisualStyleBackColor = true;
            botaomenos.Click += botaomenos_Click;
            // 
            // botaovezes
            // 
            botaovezes.FlatAppearance.BorderSize = 0;
            botaovezes.FlatStyle = FlatStyle.Flat;
            botaovezes.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            botaovezes.ForeColor = Color.FromArgb(192, 64, 0);
            botaovezes.Location = new Point(264, 172);
            botaovezes.Name = "botaovezes";
            botaovezes.Size = new Size(54, 58);
            botaovezes.TabIndex = 33;
            botaovezes.Text = "×";
            botaovezes.UseVisualStyleBackColor = true;
            botaovezes.Click += botaovezes_Click;
            // 
            // botaopotencia
            // 
            botaopotencia.FlatAppearance.BorderSize = 0;
            botaopotencia.FlatStyle = FlatStyle.Flat;
            botaopotencia.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            botaopotencia.ForeColor = Color.FromArgb(192, 64, 0);
            botaopotencia.Location = new Point(172, 108);
            botaopotencia.Name = "botaopotencia";
            botaopotencia.Size = new Size(54, 58);
            botaopotencia.TabIndex = 32;
            botaopotencia.Text = "^";
            botaopotencia.UseVisualStyleBackColor = true;
            botaopotencia.Click += botaopotencia_Click;
            // 
            // botao2
            // 
            botao2.FlatAppearance.BorderSize = 0;
            botao2.FlatStyle = FlatStyle.Flat;
            botao2.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao2.ForeColor = SystemColors.ButtonFace;
            botao2.Location = new Point(92, 302);
            botao2.Name = "botao2";
            botao2.Size = new Size(54, 58);
            botao2.TabIndex = 31;
            botao2.Text = "2";
            botao2.UseVisualStyleBackColor = true;
            botao2.Click += botao2_Click;
            // 
            // botao1
            // 
            botao1.FlatAppearance.BorderSize = 0;
            botao1.FlatStyle = FlatStyle.Flat;
            botao1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao1.ForeColor = SystemColors.ButtonFace;
            botao1.Location = new Point(12, 302);
            botao1.Name = "botao1";
            botao1.Size = new Size(54, 58);
            botao1.TabIndex = 30;
            botao1.Text = "1";
            botao1.UseVisualStyleBackColor = true;
            botao1.Click += botao1_Click;
            // 
            // botao3
            // 
            botao3.FlatAppearance.BorderSize = 0;
            botao3.FlatStyle = FlatStyle.Flat;
            botao3.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao3.ForeColor = SystemColors.ButtonFace;
            botao3.Location = new Point(172, 302);
            botao3.Name = "botao3";
            botao3.Size = new Size(54, 58);
            botao3.TabIndex = 29;
            botao3.Text = "3";
            botao3.UseVisualStyleBackColor = true;
            botao3.Click += botao3_Click;
            // 
            // botao4
            // 
            botao4.FlatAppearance.BorderSize = 0;
            botao4.FlatStyle = FlatStyle.Flat;
            botao4.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao4.ForeColor = SystemColors.ButtonFace;
            botao4.Location = new Point(12, 238);
            botao4.Name = "botao4";
            botao4.Size = new Size(54, 58);
            botao4.TabIndex = 28;
            botao4.Text = "4";
            botao4.UseVisualStyleBackColor = true;
            botao4.Click += botao4_Click;
            // 
            // botao5
            // 
            botao5.FlatAppearance.BorderSize = 0;
            botao5.FlatStyle = FlatStyle.Flat;
            botao5.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao5.ForeColor = SystemColors.ButtonFace;
            botao5.Location = new Point(92, 236);
            botao5.Name = "botao5";
            botao5.Size = new Size(54, 58);
            botao5.TabIndex = 27;
            botao5.Text = "5";
            botao5.UseVisualStyleBackColor = true;
            botao5.Click += botao5_Click;
            // 
            // botao8
            // 
            botao8.FlatAppearance.BorderSize = 0;
            botao8.FlatStyle = FlatStyle.Flat;
            botao8.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao8.ForeColor = SystemColors.ButtonFace;
            botao8.Location = new Point(92, 172);
            botao8.Name = "botao8";
            botao8.Size = new Size(54, 58);
            botao8.TabIndex = 26;
            botao8.Text = "8";
            botao8.UseVisualStyleBackColor = true;
            botao8.Click += botao8_Click;
            // 
            // botao9
            // 
            botao9.FlatAppearance.BorderSize = 0;
            botao9.FlatStyle = FlatStyle.Flat;
            botao9.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao9.ForeColor = SystemColors.ButtonFace;
            botao9.Location = new Point(172, 172);
            botao9.Name = "botao9";
            botao9.Size = new Size(54, 58);
            botao9.TabIndex = 25;
            botao9.Text = "9";
            botao9.UseVisualStyleBackColor = true;
            botao9.Click += botao9_Click;
            // 
            // botao6
            // 
            botao6.FlatAppearance.BorderSize = 0;
            botao6.FlatStyle = FlatStyle.Flat;
            botao6.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao6.ForeColor = SystemColors.ButtonFace;
            botao6.Location = new Point(172, 238);
            botao6.Name = "botao6";
            botao6.Size = new Size(54, 58);
            botao6.TabIndex = 24;
            botao6.Text = "6";
            botao6.UseVisualStyleBackColor = true;
            botao6.Click += botao6_Click;
            // 
            // botao7
            // 
            botao7.BackColor = Color.Transparent;
            botao7.FlatAppearance.BorderSize = 0;
            botao7.FlatStyle = FlatStyle.Flat;
            botao7.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao7.ForeColor = SystemColors.ButtonFace;
            botao7.Location = new Point(12, 172);
            botao7.Name = "botao7";
            botao7.Size = new Size(54, 58);
            botao7.TabIndex = 23;
            botao7.Text = "7";
            botao7.UseVisualStyleBackColor = false;
            botao7.Click += botao7_Click;
            // 
            // botao0
            // 
            botao0.FlatAppearance.BorderSize = 0;
            botao0.FlatStyle = FlatStyle.Flat;
            botao0.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            botao0.ForeColor = SystemColors.ButtonFace;
            botao0.Location = new Point(92, 367);
            botao0.Name = "botao0";
            botao0.Size = new Size(54, 58);
            botao0.TabIndex = 22;
            botao0.Text = "0";
            botao0.UseVisualStyleBackColor = true;
            botao0.Click += botao0_Click;
            // 
            // txtconta
            // 
            txtconta.BackColor = SystemColors.InactiveCaptionText;
            txtconta.BorderStyle = BorderStyle.None;
            txtconta.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtconta.ForeColor = Color.White;
            txtconta.Location = new Point(12, 12);
            txtconta.Name = "txtconta";
            txtconta.Size = new Size(322, 22);
            txtconta.TabIndex = 42;
            txtconta.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(346, 450);
            Controls.Add(txtconta);
            Controls.Add(botaovirgula);
            Controls.Add(txtresultado);
            Controls.Add(botaoC);
            Controls.Add(botaobackspace);
            Controls.Add(botaodivisao);
            Controls.Add(botaoigual);
            Controls.Add(botaoadicao);
            Controls.Add(botaomenos);
            Controls.Add(botaovezes);
            Controls.Add(botaopotencia);
            Controls.Add(botao2);
            Controls.Add(botao1);
            Controls.Add(botao3);
            Controls.Add(botao4);
            Controls.Add(botao5);
            Controls.Add(botao8);
            Controls.Add(botao9);
            Controls.Add(botao6);
            Controls.Add(botao7);
            Controls.Add(botao0);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaovirgula;
        private TextBox txtresultado;
        private Button botaoC;
        private Button botaobackspace;
        private Button botaodivisao;
        private Button botaoigual;
        private Button botaoadicao;
        private Button botaomenos;
        private Button botaovezes;
        private Button botaopotencia;
        private Button botao2;
        private Button botao1;
        private Button botao3;
        private Button botao4;
        private Button botao5;
        private Button botao8;
        private Button botao9;
        private Button botao6;
        private Button botao7;
        private Button botao0;
        private TextBox txtconta;
    }
}