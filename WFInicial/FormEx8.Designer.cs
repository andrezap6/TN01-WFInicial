namespace WFInicial
{
    partial class FormEx8
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
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            gbxOperacao = new GroupBox();
            rdbSoma = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicao = new RadioButton();
            rdbDivisao = new RadioButton();
            rdbPotenciacao = new RadioButton();
            rdbRadiciacao = new RadioButton();
            btnCalcular = new Button();
            gbxOperacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(68, 119);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(63, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Numero 1:";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(68, 166);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(63, 15);
            lblNumero2.TabIndex = 1;
            lblNumero2.Text = "Numero 2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(139, 117);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(139, 166);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            // 
            // gbxOperacao
            // 
            gbxOperacao.Controls.Add(rdbDivisao);
            gbxOperacao.Controls.Add(rdbPotenciacao);
            gbxOperacao.Controls.Add(rdbMultiplicao);
            gbxOperacao.Controls.Add(rdbRadiciacao);
            gbxOperacao.Controls.Add(rdbSubtracao);
            gbxOperacao.Controls.Add(rdbSoma);
            gbxOperacao.Location = new Point(285, 106);
            gbxOperacao.Name = "gbxOperacao";
            gbxOperacao.Size = new Size(203, 196);
            gbxOperacao.TabIndex = 4;
            gbxOperacao.TabStop = false;
            gbxOperacao.Text = "Operação";
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(9, 28);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 0;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(9, 53);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 1;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicao
            // 
            rdbMultiplicao.AutoSize = true;
            rdbMultiplicao.Location = new Point(9, 78);
            rdbMultiplicao.Name = "rdbMultiplicao";
            rdbMultiplicao.Size = new Size(97, 19);
            rdbMultiplicao.TabIndex = 2;
            rdbMultiplicao.TabStop = true;
            rdbMultiplicao.Text = "Multiplicação";
            rdbMultiplicao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(9, 103);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 3;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbPotenciacao
            // 
            rdbPotenciacao.AutoSize = true;
            rdbPotenciacao.Location = new Point(9, 128);
            rdbPotenciacao.Name = "rdbPotenciacao";
            rdbPotenciacao.Size = new Size(90, 19);
            rdbPotenciacao.TabIndex = 4;
            rdbPotenciacao.TabStop = true;
            rdbPotenciacao.Text = "Potenciação";
            rdbPotenciacao.UseVisualStyleBackColor = true;
            // 
            // rdbRadiciacao
            // 
            rdbRadiciacao.AutoSize = true;
            rdbRadiciacao.Location = new Point(9, 153);
            rdbRadiciacao.Name = "rdbRadiciacao";
            rdbRadiciacao.Size = new Size(82, 19);
            rdbRadiciacao.TabIndex = 5;
            rdbRadiciacao.TabStop = true;
            rdbRadiciacao.Text = "Radiciação";
            rdbRadiciacao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(164, 207);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(gbxOperacao);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Name = "FormEx8";
            Text = "FormEx8";
            gbxOperacao.ResumeLayout(false);
            gbxOperacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private Label lblNumero2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private GroupBox gbxOperacao;
        private RadioButton rdbDivisao;
        private RadioButton rdbPotenciacao;
        private RadioButton rdbMultiplicao;
        private RadioButton rdbRadiciacao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbSoma;
        private Button btnCalcular;
    }
}