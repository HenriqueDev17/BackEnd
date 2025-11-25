namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QtdRodas;
        public void Ligar()
        {
            Console.WriteLine($"Ligando o veiculo");
        }
        
        public void Desligar()
        {
            Console.Write($"Veiculo desligado");
        }
    }
}