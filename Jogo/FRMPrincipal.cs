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
    public partial class FRMPrincipal : Form
    {
        public List<Jogador> list;
        public FRMPrincipal(List<Jogador> lista)
        {
            InitializeComponent();
            list = lista;
        }

        private void btjogar_Click(object sender, EventArgs e)
        {
            FRMCadastro c = new FRMCadastro(list);
            c.Show();
            this.Visible = false;
        }

        private void mensair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menraking_Click(object sender, EventArgs e)
        {
            FRMRanking r = new FRMRanking(list);
            r.Show();
            this.Visible = false;
        }

        private void menjogadores_Click(object sender, EventArgs e)
        {
            FRMBuscJogador r = new FRMBuscJogador(list);
            r.Show();
            this.Visible = false;
        }
    }
}
