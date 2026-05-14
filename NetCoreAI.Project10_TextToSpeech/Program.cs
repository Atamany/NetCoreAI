using System.Speech.Synthesis;

class Program
{
    static void Main(string[] args)
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        speechSynthesizer.Volume = 100;
        speechSynthesizer.Rate = 0;
        Console.WriteLine("Metni sesli olarak okumak istediğiniz cümleyi giriniz.");
        string inputText = Console.ReadLine();
        if (!string.IsNullOrEmpty(inputText))
        {
            speechSynthesizer.Speak(inputText);
        }
    }
}