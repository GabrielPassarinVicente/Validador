namespace Validacao
{
    partial class Inicio2
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
            this.txtCPF = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnValidaCPF = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnValidaCNPJ = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.AutoSize = true;
            this.txtCPF.Location = new System.Drawing.Point(12, 56);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(89, 15);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.Text = "Digite seu CPF :";
            // 
            // mskCPF
            // 
            this.mskCPF.BackColor = System.Drawing.SystemColors.Control;
            this.mskCPF.Location = new System.Drawing.Point(114, 49);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(121, 23);
            this.mskCPF.TabIndex = 1;
            // 
            // btnValidaCPF
            // 
            this.btnValidaCPF.Location = new System.Drawing.Point(275, 50);
            this.btnValidaCPF.Name = "btnValidaCPF";
            this.btnValidaCPF.Size = new System.Drawing.Size(81, 22);
            this.btnValidaCPF.TabIndex = 2;
            this.btnValidaCPF.Text = "Validar";
            this.btnValidaCPF.UseVisualStyleBackColor = true;
            this.btnValidaCPF.Click += new System.EventHandler(this.btnValidaCPF_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.AutoSize = true;
            this.txtCNPJ.Location = new System.Drawing.Point(11, 118);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(84, 15);
            this.txtCNPJ.TabIndex = 3;
            this.txtCNPJ.Text = "Digite o CNPJ :";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(112, 110);
            this.mskCNPJ.Mask = "99,999,999/9999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(123, 23);
            this.mskCNPJ.TabIndex = 4;
            // 
            // btnValidaCNPJ
            // 
            this.btnValidaCNPJ.Location = new System.Drawing.Point(275, 113);
            this.btnValidaCNPJ.Name = "btnValidaCNPJ";
            this.btnValidaCNPJ.Size = new System.Drawing.Size(81, 25);
            this.btnValidaCNPJ.TabIndex = 5;
            this.btnValidaCNPJ.Text = "Validar";
            this.btnValidaCNPJ.UseVisualStyleBackColor = true;
            this.btnValidaCNPJ.Click += new System.EventHandler(this.btnValidaCNPJ_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(17, 181);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 6;
            // 
            // Inicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(396, 239);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnValidaCNPJ);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.btnValidaCPF);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtCPF);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inicio2";
            this.Text = "Validador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtCPF;
        private MaskedTextBox mskCPF;
        private Button btnValidaCPF;
        private Label txtCNPJ;
        private MaskedTextBox mskCNPJ;
        private Button btnValidaCNPJ;
        private Label lblMsg;
    }
}