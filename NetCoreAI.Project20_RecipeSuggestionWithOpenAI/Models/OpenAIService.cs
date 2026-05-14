using System.Text;

namespace NetCoreAI.Project20_RecipeSuggestionWithOpenAI.Models
{
    public class OpenAIService
    {
        private readonly HttpClient _httpClient;
        private const string OpenAIURL = "https://api.openai.com/v1/chat/completions";
        private const string ApiKey = "";
        public OpenAIService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        }

        public async Task<string> GetRecipeSuggestion(string ingredients)
        {
            var requestBody = new
            {
                model = "gpt-4o",
                messages = new[]
                {
                    new
                    {
                        role="system", content="Sen profesyonel bir aşçısın. Kullanıcının elindeki malzemelere göre yemek tarifi öner."
                    },new{
                        role = "user",
                        content = $"Elimde şu malzemeler var: {ingredients}. Ne yemek yapabilirim?"
                    }
                },
                temperature = 0.7
            };
            var jsonRequest = System.Text.Json.JsonSerializer.Serialize(requestBody);
            var response = await _httpClient.PostAsync(OpenAIURL, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));
            var responseBody = await response.Content.ReadAsStringAsync();
            var doc = System.Text.Json.JsonDocument.Parse(responseBody);
            return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString() ?? "Tarif bulunamadı.";
        }
    }
}
