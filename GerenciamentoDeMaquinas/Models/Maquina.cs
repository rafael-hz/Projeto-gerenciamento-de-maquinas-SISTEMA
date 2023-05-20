using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeMaquinas.Models
{
    public class Maquina
    {
        public Maquina(int estacaoDeTrabalho, string nomeLogico, string numeroSerie)
        {
            EstacaoDeTrabalho = estacaoDeTrabalho;
            NomeLogico = nomeLogico;
            NumeroSerie = numeroSerie;
        }
        public int EstacaoDeTrabalho { get; set; }
        public string NomeLogico { get; set; }
        public string NumeroSerie { get; set; }
    }
}
