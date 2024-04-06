using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDomain.Entities
{
    public class Logradouro
    {
        public int LogradouroId { get; set; }
        public string? NomeRua { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }

    }
}
