using AsignacionesMetodosNumericos.Asignacion02TabulacionFunciones;

namespace MetodosNumericos_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Tabular_RegresaResultadosCorrectos()
        {
            var tabula = new Tabula();
            Func<double, double> f = x => 2 * x + 1;

            // Act
            var result = tabula.Tabular(f, 0, 2, 1, out double xmin, out double ymin, out double xmax, out double ymax);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual((0, 1), result[0]);
            Assert.AreEqual((1, 3), result[1]);
            Assert.AreEqual((2, 5), result[2]);
            Assert.AreEqual(0, xmin);
            Assert.AreEqual(1, ymin);
            Assert.AreEqual(2, xmax);
            Assert.AreEqual(5, ymax);
        }
    }
}
