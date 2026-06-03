using NUnit.Framework;
using LogicaNegocio;

namespace LogicaNegocio.Tests
{
    public class CamionetaTests
    {
        [Test]
        public void Camioneta_CalculaRecargoCorrecto()
        {
            Camioneta camioneta = new Camioneta("DHF256", "Ricardo", 100, 2);

            decimal resultado = camioneta.CalcularPrecio(4);

            Assert.AreEqual(520, resultado);
        }
    }
}