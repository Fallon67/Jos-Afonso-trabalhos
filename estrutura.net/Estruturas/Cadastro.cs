using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 0; i -= 7)
            {

                listBoxkaneki.Items.Add(i);
            }
        }

        private void listBoxkaneki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparlbk_Click(object sender, EventArgs e)
        {
            listBoxkaneki.Items.Clear();
        }
    }
}
