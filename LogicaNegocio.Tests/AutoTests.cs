using NUnit.Framework;
using LogicaNegocio;

namespace LogicaNegocio.Tests
{
    public class AutoTests
    {
        [Test]
        public void AutoElectrico_CalculaCorrecto()
        {
            Auto auto = new Auto("ABC123", "Benja", 200, true);

            decimal resultado = auto.CalcularPrecio(3);

            Assert.AreEqual(540, resultado);
        }

        [Test]
        public void AutoNormal_CalculaSinDescuento()
        {
            Auto auto = new Auto("ABC123", "Benja", 200, false);

            decimal resultado = auto.CalcularPrecio(3);

            Assert.AreEqual(600, resultado);
        }
    }
}