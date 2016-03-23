using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Pessoa
{
    public class Fornecedor
    {        
        public DateTime UltimaCompra { get; set; } 
        public string ramo { get; set; }  //comentario      

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
