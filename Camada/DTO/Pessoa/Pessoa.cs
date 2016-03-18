using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Pessoa
{
    public abstract class Pessoa
    {
        public int id { get; set; } //Atributo auto incremento
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string Email { get; set; } //Atributo novo
    }
}
