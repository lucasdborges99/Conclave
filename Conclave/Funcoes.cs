using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conclave
{
    public class Funcoes
    { 
        public static int Lenght(string[][] v)
        {
            int q = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                    q++;
            }
            return q;
        }
        public static int Buscar(string[][] vetor, string nome)
        {
            int indice = 0;
            for (int i = 0; i < Funcoes.Lenght(vetor) && vetor[i][0] != nome; indice++)
                if (indice < Funcoes.Lenght(vetor))
                    return indice;
            return -1;
        }
    }
}
