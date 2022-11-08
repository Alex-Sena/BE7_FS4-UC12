using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //classe de testes que voce queira executar
    [TestClass]
    public class ClassificarIMCTests
    {
        //metodo de teste
        [TestMethod]
        public void ClassificarIMC()
        {
            //arrange - organizar e preparar o teste
            double imc = 28; 

            //act - agir - ececução/chamada do método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //asser - comportamento esperado , comportamento obtido
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }

}
