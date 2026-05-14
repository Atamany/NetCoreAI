using System.Text.Json;

class Program
{
    private static readonly string apiKey = "";
    static async Task Main(string[] args)
    {
        Console.Write("Hikaye Türünü Seçiniz (Macera, Korku, Bilimkurgu, Fantastik, Komedi): ");
        string genre = Console.ReadLine();
        Console.Write("Ana karakterin adını giriniz: ");
        string mainCharacter = Console.ReadLine();
        Console.Write("Hikayenin geçmesini istediğiniz yeri giriniz: ");
        string setting = Console.ReadLine();
        Console.Write("Hikayenin uzunluğunu (Kısa, Orta, Uzun) giriniz: ");
        string length = Console.ReadLine();
        int token = 0;

        if (length == "Kısa")
        {
            token = 500;
        }
        else if (length == "Orta")
        {
            token = 1000;
        }
        else if (length == "Uzun")
        {
            token = 2000;
        }

        string prompt = $"Bir {genre} hikayesi oluştur. Ana karakterin adı {mainCharacter} olsun. Hikaye {setting} yerinde geçsin ve {token} karakter uzunluğunda olsun. Giriş, Gelişme ve Sonuç içermeli.";
        string story = await GenerateStory(prompt);
        Console.WriteLine();
        Console.WriteLine("-----| Oluşturulan Hikaye: |-----");
        Console.WriteLine(story);
    }
    static async Task<string> GenerateStory(string prompt)
    {
        using (var httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            var requestBody = new
            {
                model = "gpt-4o",
                messages = new[]
                {
                    new { role = "system", content = "You are a creative story writer." },
                    new { role = "user", content = prompt }
                }
            };
            var jsonContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(requestBody), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://api.openai.com/v1/chat/completions", jsonContent);
            string responseContent = await response.Content.ReadAsStringAsync();
            JsonDocument doc = JsonDocument.Parse(responseContent);
            if (response.IsSuccessStatusCode)
            {
                return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
            }
            else
            {
                return $"Hata: {response.StatusCode}";
            }
        }
    }
}