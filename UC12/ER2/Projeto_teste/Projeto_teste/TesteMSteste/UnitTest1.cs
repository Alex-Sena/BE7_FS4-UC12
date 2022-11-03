using Projeto_teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMSteste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act - a��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - verifica��o
            Assert.AreEqual(rNum, resultado);
        }

        //Arrange
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow(2,1,3)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act - a��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - verifica��o
            Assert.AreEqual(rNum, resultado);

        }
    }
}