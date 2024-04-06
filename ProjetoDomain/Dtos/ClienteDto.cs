using ProjetoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDomain.Dtos
{
    public class ClienteDto
    {
        public int ClienteId { get; set; }
        public string? Email { get; set; }
        public string? Logotipo { get; set; }
        public List<LogradouroDto> Logradouros { get; set; } = new List<LogradouroDto>();
    }
}
