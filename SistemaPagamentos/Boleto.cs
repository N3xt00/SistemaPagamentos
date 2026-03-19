using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentos
{
    public class Boleto : Pagamento
    {
        public string CodigoBarras { get; set; }
        public DateTime DataVencimento { get; set; }

        public override void Processar()
        {
            Console.WriteLine($"Boleto gerado com sucesso. Vencimento para o dia {DataVencimento:dd/MM/yyyy}.");
        }

    }
}
