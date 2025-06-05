# Arena Savaş Oyunu (C# Konsol RPG Oyunu)

Bu, C# ile nesne yönelimli programlama (OOP) prensiplerini kullanarak hazırlanmış konsol tabanlı bir RPG savaş oyunudur.

## Proje Özellikleri
- Oyuncu ve düşman sınıfları
- Kalıtım ve polymorphism
- Statik değişken ile saldırı sayacı
- Mana ve özel yetenek sistemi
- Skor sistemi
- ASCII tabanlı arayüz

## Kaynak Kodlar
- `Karakter.cs`: Ana karakter sınıfı (base class)
- `Oyuncu.cs`: Oyuncu karakteri
- `Dusman.cs`: Zombi, Gulyabani ve Ejderha gibi düşmanlar
- `Program.cs`: Oyun motoru ve döngüsü

## Sınıf Yapısı ve OOP Açıklaması

### Kullanılan OOP Kavramları:
- **Kalıtım (Inheritance):** `Oyuncu`, `Dusman`, `Zombi`, `Ejderha` gibi sınıflar `Karakter` sınıfından türemiştir.
- **Polymorphism (Çok Biçimlilik):** `OzelYetenek` metodu override edilerek farklı düşmanlara özel saldırılar tanımlanmıştır.
- **Encapsulation (Kapsülleme):** `can`, `mana`, `guc` gibi alanlara `get/set` erişim kontrollü olarak sağlanmıştır.
- **Static Kullanımı:** Tüm saldırıların sayısı `Karakter.SaldiriSayisi` ile takip edilir.

## Proje Sahibi 
- Baki Melih POLAT
- Oyun Geliştirme ve Programlama
