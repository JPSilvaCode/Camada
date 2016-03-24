using DTO.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.id = 1;
            c1.nome = "Cliente 1";
            c1.cpf = "000.000.000-00";
            c1.rg = "AA 00.0000-00";
            c1.tipoCliente = "Consumidor Final";

            Console.WriteLine(c1.ToString());
            Console.ReadLine();
           
        }
    }
}
