namespace CodingDojoServices.Services
{
    public class DojoService
    {
        public decimal CalculaSalarioComDesconto(decimal salario, decimal desconto) => salario - desconto;
    }
}