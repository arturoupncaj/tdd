namespace TDD.App;
public class ExchangeTotalService
{
    private ExchangeService exchangeService;
    public ExchangeTotalService(ExchangeService exchangeService)
    {
        this.exchangeService = exchangeService;
    }
    
    public async Task<decimal> ObtenerMontoARecibir(decimal dolares)
    {
        decimal tipoCambio = await exchangeService.GetTipoDeCambioOficial();
        return dolares * tipoCambio;
    }
}