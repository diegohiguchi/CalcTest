using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testes
{
    [TestClass]
    public class CalculadoraTeste
    {
        [TestMethod]
        public void Deve_Calcular_Juros_Compostos() {
            // Arrange
            var juros = new TaxaJuros().Juros;
            var valorInicial = 100;
            var meses = 5;
            var esperado = (decimal)105.10;

            // Act
            var resultado = Math.Round(valorInicial * (decimal)Math.Pow(1 + juros, meses), 2, MidpointRounding.AwayFromZero);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
