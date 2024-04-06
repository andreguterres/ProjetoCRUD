using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDomain.Entities
{
    public class Cliente
    {
        //Nome, e-mail, Logotipo* e Logradouro
        public int ClienteId { get; set; }
        public string? Email { get; set; }
        public string? Logotipo { get; set; }
        public List <Logradouro> Logradouros { get; set; } = new List<Logradouro>();
    }
}
