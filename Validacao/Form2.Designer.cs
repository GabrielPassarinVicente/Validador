namespace Validacao
{
    partial class Form2
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
            this.Cadastrar = new System.Windows.Forms.Label();
            this.valida = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.contato = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.opcao = new System.Windows.Forms.Label();
            this.finalizar = new System.Windows.Forms.Button();
            this.nascimento = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.AutoSize = true;
            this.Cadastrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Cadastrar.Location = new System.Drawing.Point(111, 9);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(107, 32);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastro";
            // 
            // valida
            // 
            this.valida.Location = new System.Drawing.Point(90, 55);
            this.valida.Name = "valida";
            this.valida.Size = new System.Drawing.Size(127, 32);
            this.valida.TabIndex = 1;
            this.valida.Text = "Validar Documentos";
            this.valida.UseVisualStyleBackColor = true;
            this.valida.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(12, 111);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(46, 15);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(64, 103);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(227, 23);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 168);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 15);
            this.email.TabIndex = 4;
            this.email.Text = "Email :";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(64, 160);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(229, 23);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // contato
            // 
            this.contato.AutoSize = true;
            this.contato.Location = new System.Drawing.Point(2, 222);
            this.contato.Name = "contato";
            this.contato.Size = new System.Drawing.Size(56, 15);
            this.contato.TabIndex = 6;
            this.contato.Text = "Contato :";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(64, 214);
            this.maskedTextBox3.Mask = "(  ) 99999-9999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(103, 23);
            this.maskedTextBox3.TabIndex = 7;
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // opcao
            // 
            this.opcao.AutoSize = true;
            this.opcao.Location = new System.Drawing.Point(12, 64);
            this.opcao.Name = "opcao";
            this.opcao.Size = new System.Drawing.Size(72, 15);
            this.opcao.TabIndex = 8;
            this.opcao.Text = "CPF / CNPJ :";
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(111, 359);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(122, 34);
            this.finalizar.TabIndex = 9;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            // 
            // nascimento
            // 
            this.nascimento.AutoSize = true;
            this.nascimento.Location = new System.Drawing.Point(2, 269);
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(107, 15);
            this.nascimento.TabIndex = 10;
            this.nascimento.Text = "Data Nascimento : ";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(115, 261);
            this.maskedTextBox4.Mask = "99/99/9999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(67, 23);
            this.maskedTextBox4.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(341, 442);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.nascimento);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.opcao);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.contato);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.valida);
            this.Controls.Add(this.Cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Cadastrar;
        private Button valida;
        private Label nome;
        private MaskedTextBox maskedTextBox1;
        private Label email;
        private MaskedTextBox maskedTextBox2;
        private Label contato;
        private MaskedTextBox maskedTextBox3;
        private Label opcao;
        private Button finalizar;
        private Label nascimento;
        private MaskedTextBox maskedTextBox4;
    }
}