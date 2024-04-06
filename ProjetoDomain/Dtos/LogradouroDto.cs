using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDomain.Dtos
{
    public class LogradouroDto
    {
        public int LogradouroId { get; set; }
        public string? NomeRua { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
    }
}
