using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacFoods
{
    public class CardapioItem
    {
        public int Id { get; set; }
        //public string Titulo { get; set; } = string.Empty; assim ele não critica o titulo e etc, pois recebe um valor padrão
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool PossuiPreparo { get; set; }
    }
}
