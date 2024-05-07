using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.App;

namespace TDD.Test
{
    public class CalculadoraTest
    {
        [Test]
        public void Sumar2NumerosCaso01() {
            var calculador = new Calculadora();

            var result = calculador.Sumar(1, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Sumar2NumerosCaso02()
        {
            var calculador = new Calculadora();

            var result = calculador.Sumar(2, 1);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Sumar2NumerosCaso03()
        {
            var calculador = new Calculadora();

            var result = calculador.Sumar(-2, 1);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Sumar2NumerosCaso04()
        {
            var calculador = new Calculadora();

            var result = calculador.Sumar(-2, -1);

            Assert.AreEqual(-3, result);
        }

        [Test]
        public void Sumar2NumerosCaso05()
        {
            var calculador = new Calculadora();

            var result = calculador.Sumar(20, 11);

            Assert.AreEqual(31, result);
        }
    }
}
