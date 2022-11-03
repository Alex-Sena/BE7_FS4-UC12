using Projeto_teste;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Art
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert
            Assert.Equal(rNum, resultado);
        }

        // Arrange
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(2,1,3)]

        public void SomarDoisNumerosListar(double pNum, double sNum, double rNum)
        {
            // Art
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert
            Assert.Equal(rNum, resultado);
        }
    }
}