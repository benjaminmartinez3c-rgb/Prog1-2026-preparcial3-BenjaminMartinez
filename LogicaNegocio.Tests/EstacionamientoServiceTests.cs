using NUnit.Framework;
using LogicaNegocio;

namespace LogicaNegocio.Tests
{
    public class EstacionamientoServiceTests
    {
        [Test]
        public void AgregarYFiltrarPorNombre()
        {
            EstacionamientoService service = new EstacionamientoService();

            Auto a1 = new Auto("AAA111", "Juan", 100, false);
            Auto a2 = new Auto("BBB222", "JuAn", 100, false);
            Auto a3 = new Auto("CCC333", "Nono", 100, false);

            service.AgregarRegistro(new Registro(a1, 2));
            service.AgregarRegistro(new Registro(a2, 2));
            service.AgregarRegistro(new Registro(a3, 2));

            var resultado = service.ObtenerRegistroPorNombre("juan");

            Assert.AreEqual(2, resultado.Count);
        }

        [Test]
        public void TotalGeneral_CalculaCorrectamente()
        {
            EstacionamientoService service = new EstacionamientoService();

            Auto a1 = new Auto("AAA111", "Juancho", 100, false);
            Camioneta c1 = new Camioneta("BBB222", "Pedrolo", 100, 2);

            service.AgregarRegistro(new Registro(a1, 2)); // 200
            service.AgregarRegistro(new Registro(c1, 4)); // 520

            decimal total = service.ObtenerTotalporRegistrados();

            Assert.AreEqual(720, total);
        }

        [Test]
        public void MayorRegistro_RetornaElMasCaro()
        {
            EstacionamientoService service = new EstacionamientoService();

            Auto a1 = new Auto("AAA111", "Juan", 100, false);
            Camioneta c1 = new Camioneta("BBB222", "Roberto", 100, 4);

            service.AgregarRegistro(new Registro(a1, 2)); // 200
            service.AgregarRegistro(new Registro(c1, 4)); // 520

            var mayor = service.ObtenerMayorRegistro();

            Assert.AreEqual(520, mayor.ObtenerTotal());
        }
    }
}