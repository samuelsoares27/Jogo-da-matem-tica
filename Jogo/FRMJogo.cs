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
    public partial class FRMJogo : Form
    {
        public List<Jogador>list;
        public Jogador j = new Jogador();
        Operacao oper = new Operacao(); 

        Random x = new Random();

        DateTime h1, h2;

        string op = "";
        string nome = "";
        string nivel = "";
        Bitmap img;

        int v1 = 0, v2 = 0;
        int result = 0;

        int pont = 0;

        public FRMJogo(string op, string nv, string n, Bitmap i, List<Jogador> lista)
        {
            this.op = op;
            nome = n;
            img = i;
            nivel = nv;
            list = lista;
            InitializeComponent();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {

            lbnome.Text += " " + nome;
            lbnivel.Text += " " + nivel;
            lbtxtop.Text += " " + op;
            lbop.Text = oper.sinal(op);
            valor();

            h1 = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString("hh:mm:ss");
        }   

        private void btconfirmar_Click(object sender, EventArgs e)
        {
               
             result = oper.opresult(v1,v2,op);
             if(tbresp.Text == Convert.ToString(result))
             {
                 MessageBox.Show("Você Acertou! 1 ponto");
                 pont++;
                 
                 lbponto.Text = pont.ToString();
                 valor();
                 tbresp.Clear();
             }
            else
             {

                 h2 = DateTime.Now;

                 TimeSpan value = h2 - h1;

                 MessageBox.Show("Game Over \nO valor é " + result);
                 j.Nome = nome;
                 j.Foto = img;
                 j.Ponto = pont;
                 j.Dtinicio = value.Hours.ToString("00") + ":" + value.Minutes.ToString("00") + ":" + value.Seconds.ToString("00");
                 list.Add(j);
                 FRMRanking r = new FRMRanking(list);
                 r.Show();
                 this.Visible = false;
             }
        }

        public void valor()
        {
            if (nivel == "facil")
            {
                v1 = x.Next(0, 10);
                v2 = x.Next(0, 10);
                lbval1.Text = v1.ToString("0");
                lbval2.Text = v2.ToString("0");
            }

            if (nivel == "dificil")
            {
                v1 = x.Next(10, 99);
                v2 = x.Next(10, 99);
                lbval1.Text = v1.ToString("00");
                lbval2.Text = v2.ToString("00");
            }
        }

        private void tbresp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }

        }
     
    }
}
