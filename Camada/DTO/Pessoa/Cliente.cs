using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Pessoa
{
    public class Cliente : Pessoa
    {
        public string tipoCliente { get; set; }

        public override string ToString()
        {
            //return "Id: " + id + " Nome: " + nome;
            return string.Format("Id: {0} - Nome: {1}", this.id, this.nome);
        }
    }
}
