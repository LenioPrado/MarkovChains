using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class CadeiaMarkov
    {
        public double[,] MatrizTransicao { get; set; }
        public double[,] Simulacao{ get; set; }
        public double[,] DistribuicaoUniforme { get; set; }
        public double[,] DistribuicaoEstacionaria { get; set; }

        public CadeiaMarkov(object resultado)
        {
            object[] res = resultado as object[];

            MatrizTransicao = res[0] as double[,];
            Simulacao = res[1] as double[,];
            DistribuicaoUniforme = res[2] as double[,];
            DistribuicaoEstacionaria = res[3] as double[,];
        }
    }
}
