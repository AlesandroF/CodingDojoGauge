using CodingDojoServices.Services;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using NUnit.Framework;

namespace CodingDojoGauge.steps
{
    public class DojoStep
    {
        [Step("O funcionario recebe <salario> e com <desconto> de descontos, ele acaba recebendo liquido <resultado> reais")]
        public void calculo_do_salario(decimal salario, decimal desconto, decimal resultado)
        {
            var service = new DojoService();
            var salarioCalculado = service.CalculaSalarioComDesconto(salario, desconto);
            salarioCalculado.Should().Be(resultado);
        }

        [Test]
        public void Teste()
        {
            calculo_do_salario(1000, 100, 900);
        }
    }}