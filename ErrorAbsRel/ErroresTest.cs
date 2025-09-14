namespace AsignacionesMetodosNumericos.Tests
{
    [TestClass]
    public sealed class ErroresTest
    {
        [TestMethod]
        public void ErrorAbsoluto_ValoresPositivos_RegresaValorCorrecto()
        {
            // Arrange
            double real = 10.0;
            double aprox = 8.5;
            double esperado = 1.5;

            // Act
            double resultado = ErrorAbsRel.ErrorAbsoluto(real, aprox);

            // Assert
            Assert.AreEqual(esperado, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorAbsoluto_ValoresNegativos_RegresaValorCorrecto()
        {
            double real = -5.0;
            double aprox = -7.0;
            double esperado = 2.0;

            double resultado = ErrorAbsRel.ErrorAbsoluto(real, aprox);

            Assert.AreEqual(esperado, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorAbsoluto_ValoresIguales_RegresaCero()
        {
            double real = 3.14;
            double aprox = 3.14;
            double esperado = 0.0;

            double resultado = ErrorAbsRel.ErrorAbsoluto(real, aprox);

            Assert.AreEqual(esperado, resultado, 1e-10);
        }

        [TestMethod]
        public void ErrorRelativo_ValorNormal_RegresaPorcentajeCorrecto()
        {
            double errorAbs = 2.0;
            double real = 8.0;
            double esperado = 25.0;

            double resultado = ErrorAbsRel.ErrorRelativo(errorAbs, real);

            Assert.AreEqual(esperado, resultado, 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ErrorRelativo_ValorRealCero_LanzaExcepcion()
        {
            double errorAbs = 1.0;
            double real = 0.0;

            ErrorAbsRel.ErrorRelativo(errorAbs, real);
        }
    }
}

