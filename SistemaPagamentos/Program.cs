using SistemaPagamentos;

class Program
{
    static void Main(string[] args)
    {
        CartaoCredito cartao = new CartaoCredito
        {
            Valor = 350.00,
            Data = DateTime.Now,
            NumeroCartao = "1111 1111 1111 1111",
            Parcelas = 3
        };

        Pix pix = new Pix
        {
            Valor = 120.50,
            Data = DateTime.Now,
            ChavePix = "pagamentos@gmail.com",
            CodigoCopiaECola = "3216546513461.pix.gigi.caua"
        };

        Boleto boleto = new Boleto
        {
            Valor = 200.00,
            Data = DateTime.Now,
            CodigoBarras = "34191.75124 34567.871230 41234.560005 1 10010000020000",
            DataVencimento = new DateTime(2026, 3, 25)
        };

        cartao.Processar();
        pix.Processar();
        boleto.Processar();
    }
}
