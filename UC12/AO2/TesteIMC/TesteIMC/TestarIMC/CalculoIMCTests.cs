using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //classe de testes que voce queira executar
    [TestClass]
    public class CalculoIMCTests
    {
        //metodo de teste
        [TestMethod]
        public void CalcularIMC()
        {
            //arrange - organizar e preparar o teste
            double peso = 110;
            double altura = 1.79;

            //act - agir - ececução/chamada do método
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //asser - comportamento esperado , comportamento obtido
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
    
}
