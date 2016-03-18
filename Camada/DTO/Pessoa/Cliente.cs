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
        public string classificacao { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} - Nome: {1} - CPF: {2} - Tipo: {3}", id, nome, cpf, tipoCliente);
        }
    }
}
