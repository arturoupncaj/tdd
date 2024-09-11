using System.Text.Json;

namespace TDD.App;

public class ApiResponse
{
    public decimal conversion_rate { get; set; }
}

public class ExchangeService
{
    public async Task<decimal> GetTipoDeCambioOficial()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send a GET request
                var response = await client.GetAsync("https://v6.exchangerate-api.com/v6/b6841dc41364116a8b88e0f1/pair/USD/PEN");

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string responseData = await response.Content.ReadAsStringAsync();
                    ApiResponse apiResponse = JsonSerializer.Deserialize<ApiResponse>(responseData);
                    return apiResponse.conversion_rate;
                }

                throw new Exception();
            }
            catch (HttpRequestException e)
            {
                // Handle any errors that occur during the request
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
        
        return 3.7m;
    }
}