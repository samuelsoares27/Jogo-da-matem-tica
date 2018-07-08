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
    public partial class FRMRanking : Form
    {
        List<Jogador> list;
        public FRMRanking(List<Jogador> lista)
        { 
            InitializeComponent();
            list = lista;
            int i = 1;
            foreach (Jogador item in list.OrderByDescending(x=>x.Ponto))
            {
                lblist.Items.Add(Convert.ToString (i + " - " + "Nome: " + item.Nome +" | Tempo: " + item.Dtinicio.ToString() + " | Pontos: " + item.Ponto));
                i++;
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            FRMPrincipal p = new FRMPrincipal(list);
            p.Show();
            this.Visible = false;
        }
    }
}
