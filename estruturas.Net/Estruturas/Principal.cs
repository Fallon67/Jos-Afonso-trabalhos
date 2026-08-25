using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "EvilFalacio";
            string senha = "malnoite456!";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJurosSimples_Click(object sender, EventArgs e)
        {
            int meses = 5;
            decimal taxa = 3.5m;
            decimal capital = 100;
            lsbMostra.Items.Clear();
            decimal juros = 1;

            taxa = taxa / 100;

            juros = capital * meses * taxa;
            lsbMostra.Items.Add(juros.ToString());

        }

        private void btnMontante_Click(object sender, EventArgs e)
        {
            int meses = 5;
            decimal taxa = 3.5m;
            decimal capital = 100;
            decimal juros = 1;
            decimal montante = 1;
            lsbMostra.Items.Clear();

            taxa = taxa / 100;
            juros = capital * meses * taxa;
            montante = capital + juros;
            lsbMostra.Items.Add(montante.ToString());
        }

        private void btnJurosComp_Click(object sender, EventArgs e)
        {
            int meses = 5;
            decimal taxa = 3.5m;
            decimal capital = 100;
            lsbMostra.Items.Clear();

            decimal montante = 1;
            taxa = taxa / 100;
            montante = Math.Round(capital * (decimal)Math.Pow((double)(1 + taxa), meses), 2);
            lsbMostra.Items.Add(montante.ToString());
        }

        private void btnCalculaJ_Click(object sender, EventArgs e)
        {
            string url = "https://www3.bcb.gov.br/CALCIDADAO/publico/exibirFormFinanciamentoPrestacoesFixas.do?method=exibirFormFinanciamentoPrestacoesFixas";
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "chrome.exe",
                Arguments = url,
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnBlocodn_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btnBobEsp_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=p-hUSmzQh1U&pp=ygUHcmVkbWlzdA%3D%3D";
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "chrome.exe",
                Arguments = url,
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void btnCreepypasta_Click(object sender, EventArgs e)
        {
            string url = "https://pt.wikipedia.org/wiki/Creepypasta";
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "chrome.exe",
                Arguments = url,
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void btnLimparlsb1_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();
        }
    }
}

