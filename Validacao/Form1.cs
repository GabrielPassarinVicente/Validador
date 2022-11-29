namespace Validacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnValidaCPF_Click(object sender, EventArgs e)

        {


            if (Validacoes.ValidaCPF(mskCPF.Text))

                lblMsg.Text = "CPF Válido!";

            else

                lblMsg.Text = "CPF Inválido!";

        }
        private void btnValidaCNPJ_Click( object sender, EventArgs e)

        {

            if (Validacao.ValidaCNPJ(mskCNPJ.Text))

                lblMsg.Text = "CNPJ Válido!";
            else

                lblMsg.Text = "CNPJ Inválido!";

        }
    }
}