using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentos
{
    public abstract class Pagamento
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public virtual void Processar()
        {
            Console.WriteLine("Iniciando pagamento...");
        }

    }
}
