namespace SistemaCadastro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void adicionarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addfuncionario add = new addfuncionario();
            add.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_adc_Click(object sender, EventArgs e)
        {
            addfuncionario ad = new addfuncionario();
            ad.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}