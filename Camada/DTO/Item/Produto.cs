using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Item
{
    public class Produto
    {

        public override string ToString()
        {
            return base.ToString();
        }
        public int id { get; set; }
        public string descricao { get; set; }
    }
}
