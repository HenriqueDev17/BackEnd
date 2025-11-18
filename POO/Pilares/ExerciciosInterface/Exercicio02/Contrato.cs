namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";
        public string Contratante = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;

        }
        public void Imprimir()
        {
            Console.WriteLine($@"
            Partes:
                Contratante: {Contratante}
                Contratada: {PrestadorServico}
                Cláusulas do contrato:

                {TextoClausulas}
                
            ");
        }
    }
}