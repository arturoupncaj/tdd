using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.App;

namespace TDD.Test
{
    public class ExchangeServiceTest
    {

        // void = async Task
        [Test]
        // depende de conectividad a intenet
        public async Task Prueba1() {

            var exchange = new ExchangeService();
            var tipoCambio = await exchange.GetTipoDeCambioOficial();

            Assert.Greater(tipoCambio, 0);
        }
    }
}
