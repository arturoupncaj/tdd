using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.App
{
    public class CasaDeCambio
    {
        private IExchangeService exchange;
        public CasaDeCambio(IExchangeService exchange)
        {
            this.exchange = exchange;
        }

        public async Task<decimal> EstimarMontoARecibir(decimal dolares) {
            var tipoDeCambio = await exchange.GetTipoDeCambioOficial();          
            return dolares * tipoDeCambio; // mi objetivo
        }
    }
}
