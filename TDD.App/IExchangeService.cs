using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.App
{
    public interface IExchangeService
    {
        Task<decimal> GetTipoDeCambioOficial();
    }
}
