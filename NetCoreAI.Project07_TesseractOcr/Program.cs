using Tesseract;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Karakter Okumasu Yapılacak Resim Yolu:");
        string imagePath = Console.ReadLine();
        string tessDataPath = @"C:\tessdata";
        try
        {
            using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(imagePath))
                {
                    using (var page = engine.Process(img))
                    {
                        string text = page.GetText();
                        Console.WriteLine("Resimden Okunan Metin:");
                        Console.WriteLine(text);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }
}