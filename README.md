# 🤖 NetCoreAI - C# .NET ile Yapay Zeka Entegrasyonları

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Language](https://img.shields.io/badge/language-C%23-239120.svg)](https://dotnet.microsoft.com/)
[![Framework](https://img.shields.io/badge/framework-.NET%20Core-blueviolet.svg)](https://dotnet.microsoft.com/)

Murat Yücedağ tarafından Udemy üzerinde verilen **"C# .NET ile Yapay Zeka Entegrasyonları"** eğitiminde geliştirilen 20 praktikal proje koleksiyonu.

## 📚 Hakkında

Bu repository, OpenAI, Google Cloud Vision, Tesseract OCR ve diğer modern yapay zeka hizmetlerini C# .NET Core uygulamalarına entegre etmenin pratik örneklerini içerir. Her proje, belirli bir yapay zeka teknolojisinin kullanımını ve uygulamasını göstermektedir.

**Teknoloji Stack:**
- ![C#](https://img.shields.io/badge/C%23-74.3%25-239120?style=flat)
- ![HTML](https://img.shields.io/badge/HTML-20.6%25-E34C26?style=flat)
- ![CSS](https://img.shields.io/badge/CSS-4.4%25-1572B6?style=flat)
- ![JavaScript](https://img.shields.io/badge/JavaScript-0.7%25-F7DF1E?style=flat)

## 🎯 Proje Listesi

### 1. **Project01_ApiDemo**
API'ların temel kullanımı ve entegrasyon prensiplerini gösteren temel proje.

### 2. **Project02_ApiConsumeUI**
API'den veri tüketen ve kullanıcı arayüzü sunan web uygulaması.

### 3. **Project03_RapidApi**
RapidAPI platformu üzerinden çeşitli hizmetlere erişim ve kullanım örneği.

### 4. **Project04_OpenAIChat** 🤖
OpenAI API'sini kullanarak sohbet botunun geliştirilmesi. ChatGPT gibi etkileşimli sohbet uygulaması.

### 5. **Project05_OpenAIWhisperAudioTranskript** 🎤
OpenAI Whisper API'sini kullanarak ses dosyalarının metne çevrilmesi (Speech-to-Text).

### 6. **Project06_DallEImageGeneration** 🖼️
DALL-E API'sini kullanarak metinsel açıklamalardan görsel üretimi.

### 7. **Project07_TesseractOcr** 📄
Tesseract OCR kütüphanesini kullanarak görüntülerden metin ayıklama (Optical Character Recognition).

### 8. **Project08_GoogleCloudVision** 👁️
Google Cloud Vision API'sini kullanarak görüntü analizi ve nesne tanıma.

### 9. **Project09_OpenAITranslate** 🌍
OpenAI API'sini kullanarak metin çevirisi ve çok dilli destek.

### 10. **Project10_TextToSpeech** 🔊
Metin-to-sesli dönüşüm (Text-to-Speech) işlevselliği.

### 11. **Project11_TextToSpeechWithOpenAI** 🎵
OpenAI TTS API'sini kullanarak doğal sesle metin okuma.

### 12. **Project12_SentimentAIApp** 💭
Duygu analizi (Sentiment Analysis) yapan yapay zeka uygulaması. Metinlerin duygusal tonunu belirleme.

### 13. **Project13_SentimentWithDegreeAIApp** 📊
Gelişmiş duygu analizi - duyguların derecesiyle birlikte analiz.

### 14. **Project14_ArticalSummarizeAI** 📰
Yazı ve makaleleri özetleyen yapay zeka uygulaması.

### 15. **Project15_WebScrapingWithOpenAIApi** 🕷️
Web sayfalarından veri çekme ve OpenAI API'sı ile analiz etme.

### 16. **Project16_PDFAnalyzeWithOpenAI** 📑
PDF dosyalarını analiz etmek ve bilgi çıkarmak için OpenAI entegrasyonu.

### 17. **Project17_GoogleCloudVisionImageDetection** 🔍
Google Cloud Vision kullanarak detaylı görüntü algılama ve sınıflandırma.

### 18. **Project18_OpenAINewsSummarizeWithRSS** 📺
RSS feed'lerinden haber alıp OpenAI ile özetleyen uygulama.

### 19. **Project19_CreateStoryWithAI** 📖
OpenAI API'sini kullanarak otomatik hikaye üretimi.

### 20. **Project20_RecipeSuggestionWithOpenAI** 👨‍🍳
Yapay zeka tabanlı tarif önerme uygulaması - bileşenlerden tarif oluşturma.

---

## 🚀 Başlamak

### Sistem Gereksinimleri
- .NET 6.0 veya daha yüksek
- Visual Studio 2022 veya Visual Studio Code
- Gerekli NuGet paketleri

### Kurulum

1. Depoyu klonlayın:
```bash
git clone https://github.com/Atamany/NetCoreAI.git
cd NetCoreAI
```

2. Solution dosyasını açın:
```bash
dotnet open NetCoreAI.sln
```

3. Bağımlılıkları yükleyin:
```bash
dotnet restore
```

4. İlgili proje dizinine gidin ve çalıştırın:
```bash
cd NetCoreAI.Project01_ApiDemo
dotnet run
```

## 🔑 API Anahtarları ve Konfigürasyon

Projelerin çoğu dış API hizmetleri kullanır. Çalıştırmadan önce ilgili API anahtarlarını almak gerekir:

### OpenAI API
- [platform.openai.com](https://platform.openai.com) adresinden API anahtarı alın
- `appsettings.json` veya ortam değişkenlerine anahtarı ekleyin

### Google Cloud Vision
- Google Cloud Console'da proje oluşturun
- Vision API'sini etkinleştirin
- Hizmet hesabı anahtarını indirin

### RapidAPI
- [rapidapi.com](https://rapidapi.com) adresinden hesap oluşturun
- Gerekli API'ları abone olun
- API anahtarını proje konfigürasyonuna ekleyin

### Tesseract OCR
- Tesseract OCR'yi sisteminize yükleyin
- [GitHub - UB-Mannheim/tesseract](https://github.com/UB-Mannheim/tesseract/wiki) adresinden indirin

## 📋 Proje Yapısı

```
NetCoreAI/
├── NetCoreAI.Project01_ApiDemo/
├── NetCoreAI.Project02_ApiConsumeUI/
├── NetCoreAI.Project03_RapidApi/
├── ...
├── NetCoreAI.Project20_RecipeSuggestionWithOpenAI/
├── NetCoreAI.sln
└── README.md
```

## 🛠️ Teknolojiler ve Kütüphaneler

- **ASP.NET Core** - Web framework
- **OpenAI API** - ChatGPT, DALL-E, Whisper, TTS
- **Google Cloud Vision** - Görüntü analizi
- **Tesseract OCR** - Karakter tanıma
- **Newtonsoft.Json** - JSON işleme
- **HttpClient** - API istekleri

## 💡 Kullanım Örnekleri

### OpenAI Chat Bot
```csharp
var client = new OpenAIClient(apiKey);
var response = await client.ChatCompletion.CreateChatCompletion(
    new ChatCompletionCreateRequest
    {
        Model = "gpt-3.5-turbo",
        Messages = new List<ChatMessage>
        {
            new ChatMessage(ChatMessageRole.User, "Selam, nasılsın?")
        }
    }
);
```

### Görüntü Tanıma (Google Cloud Vision)
```csharp
var client = ImageAnnotatorClient.Create();
var image = Image.FromFile("path/to/image.jpg");
var response = client.DetectLabels(image);
foreach (var annotation in response)
{
    Console.WriteLine($"Label: {annotation.Description}, Confidence: {annotation.Score}");
}
```

## 📖 Öğrenme Yolculuğu

Bu projeler şu konuları kapsamaktadır:

1. **API Entegrasyonu Temelleri** - Başlangıç ve API kullanımı
2. **Doğal Dil İşleme (NLP)** - Sohbet, çeviri, duygu analizi
3. **Görüntü İşleme** - OCR, görüntü analizi, nesne tanıma
4. **Ses İşleme** - Ses transkripti, metin-to-sesli
5. **İçerik Üretimi** - Yazı, hikaye, tarif önerme
6. **Web Scraping** - Veri çekme ve analiz
7. **Gelişmiş Uygulamalar** - PDF analizi, RSS entegrasyonu

## 🎓 Eğitim Kaynağı

Bu proje seti, Udemy üzerindeki **"C# .NET ile Yapay Zeka Entegrasyonları"** eğitimini takip eden öğrenciler için rehber görevini görmektedir.

## 🤝 Katkıda Bulunmak

Katkılarınızı bekliyoruz! Eğer:
- Hata bulursanız
- Iyileştirme öneriniz varsa
- Yeni örnekler eklemek istiyorsanız

Pull request gönderebilir veya issue açabilirsiniz.

## 📝 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakınız.

## 👤 İletişim

**Geliştirici:** Atamany  
**GitHub:** [@Atamany](https://github.com/Atamany)  
**Proje:** [NetCoreAI Repository](https://github.com/Atamany/NetCoreAI)

---

## ⭐ Projeyi Beğendiyseniz

Eğer bu proje sizin için faydalı olduysa, lütfen bir yıldız ⭐ verin!

---

## 📚 Kaynaklar ve İlgili Linkler

- [OpenAI Documentation](https://platform.openai.com/docs)
- [Google Cloud Vision API](https://cloud.google.com/vision/docs)
- [Tesseract OCR](https://github.com/UB-Mannheim/tesseract/wiki)
- [Microsoft .NET Documentation](https://docs.microsoft.com/dotnet)
- [RapidAPI](https://rapidapi.com)

---

**Son Güncelleme:** 14 Mayıs 2026

Mutlu kodlamalar! 🚀
