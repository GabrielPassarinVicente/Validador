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

                lblMsg.Text = "CPF V�lido!";

            else

                lblMsg.Text = "CPF Inv�lido!";

        }
        private void btnValidaCNPJ_Click( object sender, EventArgs e)

        {

            if (Validacao.ValidaCNPJ(mskCNPJ.Text))

                lblMsg.Text = "CNPJ V�lido!";
            else

                lblMsg.Text = "CNPJ Inv�lido!";

        }
    }
}