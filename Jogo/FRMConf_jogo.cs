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

    public partial class FRMConf_jogo : Form
    {
        List<Jogador> list;
        public string op = "", nv = "";
        string n;
        Bitmap img;

        public FRMConf_jogo(string n, Bitmap i, List<Jogador> lista)
        {
            InitializeComponent();
            this.n = n;
            this.img = i;
            list = lista;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //seleção da operação
            if(rbsoma.Checked)
            {
                op = "soma";
            }
            if (rbsubitracao.Checked)
            {
                op = "subtracao";
            }
            if (rbdivisao.Checked)
            {
                op = "divisao";
            }
            if (rbmultiplicacao.Checked)
            {
                op = "multiplicacao";
            }

            //seleção do nivel
            if (rbfacil.Checked)
            {
                nv = "facil";
            }
            if (rbdificil.Checked)
            {
                nv = "dificil";
            }
            
            if((op != "") && (nv != ""))
            {
                FRMJogo jog = new FRMJogo(op,nv,n,img,list);
                jog.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecione todas as opções!");
            }
            
        }
    }
}
