namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasAtraso = 0;
        private float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valFat;
            DiasAtraso = qtdAtraso;
        
        }

        public void Imprimir()
        {
            Console.WriteLine($@"
            Credor: {Credor}
            Devedor: {Devedor}
            Dias de atraso: {DiasAtraso} dias(s)
            Valor: R${ Valor:F2}
            Júros: R${ (Juros * DiasAtraso):F2}
            Total Com Júros: R${Valor:F2}
            ");
        }

        public void CalcularValorDivida() 
        {
            if(DiasAtraso > 0 )
            {
                Valor = Valor + DiasAtraso * Juros;
            }
            if(DiasAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}

