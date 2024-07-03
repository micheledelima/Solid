namespace Solid
{
    public interface IDesconto
    {
        double Calcular(double valorCompra);
    }

    public class DescontoRegular : IDesconto
    {
        public double Calcular(double valorCompra)
        {
            return valorCompra * 0.05;
        }
    }

    public class DescontoPremium : IDesconto
    {
        public double Calcular(double valorCompra)
        {
            return valorCompra * 0.10;
        }
    }

    public class DescontoVIP : IDesconto
    {
        public double Calcular(double valorCompra)
        {
            return valorCompra * 0.15;
        }
    }

    public class CalculadoraPreco
    {
        private readonly IDesconto desconto;

        public CalculadoraPreco(IDesconto desconto)
        {
            this.desconto = desconto;
        }

        public double CalcularPreco(double valorCompra)
        {
            return valorCompra - desconto.Calcular(valorCompra);
        }
    }

    //public partial class Program
    //{
    //    public static void Main()
    //    {
    //        // Simulando injeção de dependência
    //        IDesconto descontoVIP = new DescontoVIP();
    //        var calculadoraVIP = new CalculadoraPreco(descontoVIP);
    //        double preco = calculadoraVIP.CalcularPreco(1000);
    //        Console.WriteLine($"Preço para VIP: {preco}");

    //        IDesconto descontoPremium = new DescontoPremium();
    //        var calculadoraPremium = new CalculadoraPreco(descontoPremium);
    //        preco = calculadoraPremium.CalcularPreco(1000);
    //        Console.WriteLine($"Preço para Premium: {preco}");

    //        IDesconto descontoRegular = new DescontoRegular();
    //        var calculadoraRegular = new CalculadoraPreco(descontoRegular);
    //        preco = calculadoraRegular.CalcularPreco(1000);
    //        Console.WriteLine($"Preço para Regular: {preco}");
    //    }
    //}
}
