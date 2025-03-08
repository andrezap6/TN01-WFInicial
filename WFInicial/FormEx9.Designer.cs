namespace WFInicial
{
    partial class FormEx9
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
            lblNomeUsuario = new Label();
            lblSenhaUsuario = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(44, 64);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(50, 15);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "Usuario:";
            // 
            // lblSenhaUsuario
            // 
            lblSenhaUsuario.AutoSize = true;
            lblSenhaUsuario.Location = new Point(44, 101);
            lblSenhaUsuario.Name = "lblSenhaUsuario";
            lblSenhaUsuario.Size = new Size(42, 15);
            lblSenhaUsuario.TabIndex = 1;
            lblSenhaUsuario.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(140, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(140, 93);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(165, 135);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormEx9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 316);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenhaUsuario);
            Controls.Add(lblNomeUsuario);
            Name = "FormEx9";
            Text = "FormEx9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeUsuario;
        private Label lblSenhaUsuario;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}