namespace WFInicial
{
    partial class FormEx6
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
            lblNome = new Label();
            button1 = new Button();
            txtNome = new TextBox();
            txtValorHora = new TextBox();
            txtQuantHoras = new TextBox();
            lblQuantHoras = new Label();
            lblValorHora = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(76, 96);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(214, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(214, 93);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(183, 23);
            txtNome.TabIndex = 2;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(214, 125);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 3;
            // 
            // txtQuantHoras
            // 
            txtQuantHoras.Location = new Point(214, 154);
            txtQuantHoras.Name = "txtQuantHoras";
            txtQuantHoras.Size = new Size(100, 23);
            txtQuantHoras.TabIndex = 4;
            // 
            // lblQuantHoras
            // 
            lblQuantHoras.AutoSize = true;
            lblQuantHoras.Location = new Point(76, 153);
            lblQuantHoras.Name = "lblQuantHoras";
            lblQuantHoras.Size = new Size(122, 15);
            lblQuantHoras.TabIndex = 5;
            lblQuantHoras.Text = "Quantidade de Horas:";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(76, 125);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(81, 15);
            lblValorHora.TabIndex = 6;
            lblValorHora.Text = "Valor da Hora:";
            lblValorHora.Click += label2_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 380);
            Controls.Add(lblValorHora);
            Controls.Add(lblQuantHoras);
            Controls.Add(txtQuantHoras);
            Controls.Add(txtValorHora);
            Controls.Add(txtNome);
            Controls.Add(button1);
            Controls.Add(lblNome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button button1;
        private TextBox txtNome;
        private TextBox txtValorHora;
        private TextBox txtQuantHoras;
        private Label lblQuantHoras;
        private Label lblValorHora;
    }
}