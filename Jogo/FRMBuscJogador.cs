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
    public partial class FRMBuscJogador : Form
    {
        List<Jogador> list;

        public FRMBuscJogador(List<Jogador> lista)
        {
            InitializeComponent();
            list = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Jogador item in list)
            {
                if(tbnomebusc.Text == item.Nome)
                {
                    imgjogador.Image = item.Foto;
                    lbnome.Text = "Nome: " + item.Nome;
                    lbtempo.Text = "Tempo: " + item.Dtinicio;
                    lbponto.Text = item.Ponto.ToString("0");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMPrincipal p = new FRMPrincipal(list);
            p.Show();
            this.Visible = false;
        }
    }
}
