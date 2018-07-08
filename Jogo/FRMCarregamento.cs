using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class FRMCarregamento : Form
    {
        List<Jogador> list = new List<Jogador>();
        public FRMCarregamento(List<Jogador> lista)
        {
            InitializeComponent();
            list = lista;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                FRMPrincipal p = new FRMPrincipal(list);
                p.Show();
                this.Visible = false;
            }
        }

    }
}
