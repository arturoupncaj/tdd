using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.App;

namespace TDD.Test
{
    public class ExchangeServiceFake : IExchangeService
    {
        public async Task<decimal> GetTipoDeCambioOficial()
        {
            return 3.8m;
        }
    }

    public class CasaDeCambioTest
    {
        [Test]
        // prueba unitario
        public async Task EstimarMontoARecibirTest1() {            
            var casaCambio = new CasaDeCambio(new ExchangeServiceFake());
            var monto = 1000m;           
            var total = await casaCambio.EstimarMontoARecibir(monto);
            Assert.AreEqual(total, 3800m);
        }

        [Test]
        // prueba integral
        public async Task EstimarMontoARecibirTest1Integracion()
        {
            var casaCambio = new CasaDeCambio(new ExchangeService());
            var monto = 1000m;
            var total = await casaCambio.EstimarMontoARecibir(monto);
            Assert.Greater(total, 3000m);
        }
    }
}
