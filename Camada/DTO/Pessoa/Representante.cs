using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Pessoa
{
    public class Representante : Pessoa
    {
        public string tipo { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} - Nome: {1} - CPF: {2} - Tipo: {3}", id, nome, cpf, tipo);
        }
    }
}
