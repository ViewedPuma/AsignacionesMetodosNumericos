using AsignacionesMetodosNumericos.Error_Absoluto;

namespace ErroresTest

{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ErrorAbsoluto_ValoresPositivos_RegresaDiferenciaAbsoluta()
        {
            double valorReal = 10.0;
            double valorAproximado = 7.5;

            double resultado = ErrorAbsRel.ErrorAbsoluto(valorReal, valorAproximado);

            Assert.AreEqual(2.5, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorAbsoluto_ValoresNegativos_RegresaDiferenciaAbsoluta()
        {
            double valorReal = -5.0;
            double valorAproximado = -8.0;

            double resultado = ErrorAbsRel.ErrorAbsoluto(valorReal, valorAproximado);

            Assert.AreEqual(3.0, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorAbsoluto_ValorRealMayor_RegresaDiferenciaAbsoluta()
        {
            double valorReal = 15.0;
            double valorAproximado = 10.0;

            double resultado = ErrorAbsRel.ErrorAbsoluto(valorReal, valorAproximado);

            Assert.AreEqual(5.0, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorAbsoluto_ValorAproximadoMayor_RegresaDiferenciaAbsoluta()
        {
            double valorReal = 3.0;
            double valorAproximado = 7.0;

            double resultado = ErrorAbsRel.ErrorAbsoluto(valorReal, valorAproximado);

            Assert.AreEqual(4.0, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorAbsoluto_ValoresIguales_RegresaCero()
        {
            double valorReal = 5.0;
            double valorAproximado = 5.0;

            double resultado = ErrorAbsRel.ErrorAbsoluto(valorReal, valorAproximado);

            Assert.AreEqual(0.0, resultado, 1e-10);
        }
    }
}
