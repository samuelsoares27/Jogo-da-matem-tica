using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Operacao
    {
        private int result;

        public int opresult(int v1, int v2, string op)
        {
            switch(op)
            {
                case "soma":
                    result = v1 + v2;
                    break;
                case "subtracao":
                    result = v1 - v2;
                    break;
                case "divisao":
                    result = (int) v1 / v2;
                    break;
                case "multiplicacao":
                    result = v1 * v2;
                    break;
            }
            return result;
        }
        public string sinal(string op)
        {
            string val = "";

            if (op == "soma")
            { val = "+"; }
            if (op == "subtracao")
            { val = "-"; }
            if (op == "divisao")
            { val = "/"; }
            if (op == "multiplicacao")
            { val = "*"; }

            return val;
        }

    }
}
