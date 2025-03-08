namespace WFInicial
{
    partial class FormEx12
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
            lblNumero = new Label();
            lbl0 = new Label();
            lblNome = new Label();
            lblPar = new Label();
            btnAdicionar = new Button();
            txtNumero = new TextBox();
            lblImpar = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(70, 69);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lbl0
            // 
            lbl0.AutoSize = true;
            lbl0.Location = new Point(302, 69);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(13, 15);
            lbl0.TabIndex = 1;
            lbl0.Text = "0";
            // 
            // lblNome
            // 
            lblNome.BorderStyle = BorderStyle.Fixed3D;
            lblNome.Location = new Point(70, 151);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 2;
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPar
            // 
            lblPar.BorderStyle = BorderStyle.Fixed3D;
            lblPar.Location = new Point(70, 183);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(100, 23);
            lblPar.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(209, 101);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(130, 61);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(154, 23);
            txtNumero.TabIndex = 6;
            // 
            // lblImpar
            // 
            lblImpar.BorderStyle = BorderStyle.Fixed3D;
            lblImpar.Location = new Point(70, 219);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(100, 23);
            lblImpar.TabIndex = 7;
            // 
            // FormEx12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblImpar);
            Controls.Add(txtNumero);
            Controls.Add(btnAdicionar);
            Controls.Add(lblPar);
            Controls.Add(lblNome);
            Controls.Add(lbl0);
            Controls.Add(lblNumero);
            Name = "FormEx12";
            Text = "FormEx12";
            Load += FormEx12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lbl0;
        private Label lblNome;
        private Label lblPar;
        private Button btnAdicionar;
        private TextBox txtNumero;
        private Label lblImpar;
    }
}