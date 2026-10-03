using Xunit;
using CalculadoraDescontos.App;
using CalculadoraDescontos;

namespace CalculadoraDescontos.Tests;

public class DescontoServiceTests
{
	[Theory]
	[InlineData(2, "BRONZE")]
	[InlineData(7, "PRATA")]
	[InlineData(15, "OURO")]
	public void DeveClassificarCategoria(int totalCompras, string categoriaEsperada)
	{
		var calculadora = new DescontoService();

		var categoria = calculadora.ObterCategoriaCliente(totalCompras);

		Assert.Equal(categoriaEsperada, categoria);
	}

	[Theory]
	[InlineData(100, 10, 90)]
	[InlineData(200, 20, 160)]
	[InlineData(50, 0, 50)]
	public void DeveCalcularDesconto(int valor, int percentual, int valorEsperado)
	{
		var calculadora = new DescontoService();

		var resultado = calculadora.CalcularDescontoPorPercentual(valor, percentual);

		Assert.Equal(valorEsperado, resultado);
	}

	[Theory]
	[InlineData(20, false, true)]
	[InlineData(16, true, true)]
	[InlineData(17, false, false)]
	public void DeveValidarElegibilidadeAoCupom(int idade, bool primeiraCompra, bool elegivelEsperado)
	{
		var calculadora = new DescontoService();

		var elegivel = calculadora.EValidoParaCupom(idade, primeiraCompra);

		Assert.Equal(elegivelEsperado, elegivel);
	}
}
