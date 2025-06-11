using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacFoods
{
    public class Comanda
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public int Situacao { get; set; }
        public string NomeCliente { get; set; }
        public int SituacaoComanda { get; set; }

    }
}
