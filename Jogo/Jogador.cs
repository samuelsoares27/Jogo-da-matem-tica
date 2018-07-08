using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Jogo
{
    public class Jogador
    {
        private string nome;
        private int ponto;
        private Bitmap foto;
        private string dtinicio;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Ponto
        {
            get { return ponto; }
            set { ponto = value; }
        }

        public Bitmap Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public string Dtinicio
        {
            get { return dtinicio; }
            set { dtinicio = value; }
        }

        public Jogador(){}
    }
}
