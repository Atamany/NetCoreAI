using Newtonsoft.Json;

class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Çevirmek istediğiniz cümleyi giriniz.");
        string inputText = Console.ReadLine();
        string apiKey = "YOUR_OPENAI_API_KEY";
        string translatedText = await TranslateTextAsync(inputText, apiKey);
        if (!string.IsNullOrEmpty(translatedText))
        {
            Console.WriteLine();
            Console.WriteLine("Çeviri (İngilizce): " + translatedText);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Çeviri başarısız oldu.");
        }
    }
    private static async Task<string> TranslateTextAsync(string inputText, string apiKey)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = $"You are a helpful translator." },
                    new { role = "user", content = $"Please translate this text to English: {inputText}" }
                }
            };
            string jsonBody = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(responseString);
                string translation = responseObject.choices[0].message.content;
                return translation;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return null;
            }
        }
    }
}