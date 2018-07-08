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
    public partial class FRMCadastro : Form
    {
        public Jogador j = new Jogador();
        private Bitmap img;
        private string nome = "";

        public List<Jogador> list;

        public FRMCadastro(List<Jogador> lista)
        {
            InitializeComponent();
            list = lista;
        }

        private void btconfirmar_Click(object sender, EventArgs e)
        {
            nome = tbnome.Text;

            if (nome != "")
            {
                FRMConf_jogo cfj = new FRMConf_jogo(nome, img, list);
                cfj.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Coloque um nome.");
            }
        }

        private void pbimg_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog1.FileName);
                pbimg.Image = img;
            }
        }
    }
}
