using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Spor_Porjesi.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int SecilenKilo { get; set; }

        public string? TavsiyeBaslik { get; set; }
        public string? TavsiyeDetay { get; set; }

        // Eklenen Beslenme & Makro Alanları
        public int GunlukKalori { get; set; }
        public int ProteinGram { get; set; }
        public int KarbonhidratGram { get; set; }
        public int YagGram { get; set; }
        public string? BeslenmeDetay { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (SecilenKilo >= 45 && SecilenKilo < 55)
            {
                TavsiyeBaslik = "Kategori: Yüksek Kalori İhtiyacı / Hacim (Bulk)";
                TavsiyeDetay = "Amaç: Vücudu antrenmana alıştırmak, temel kuvvet ve hareket tekniğini geliştirmek. Haftada 3 gün Full-Body, 2-3 set x 10-15 tekrar. Squat, lunge, bench press, row, lat pulldown.";

                GunlukKalori = SecilenKilo * 42;
                ProteinGram = (int)(SecilenKilo * 2.0);
                KarbonhidratGram = (int)(SecilenKilo * 5.5);
                YagGram = (int)(SecilenKilo * 1.1);
                BeslenmeDetay = "Günde 4-5 öğün beslenin, sıvı kalorilerden (fıstık ezmeli shake) destek alın ve pirinç, yulaf gibi kompleks karbonhidratları artırın.";
            }
            else if (SecilenKilo >= 55 && SecilenKilo < 65)
            {
                TavsiyeBaslik = "Kategori: Kilo Alma / Kas Kazanımı";
                TavsiyeDetay = "Amaç: Kas kütlesini artırmak. Haftada 3-4 gün Upper/Lower veya Full-Body. Temel hareketlerde 3-4 x 8-12. Günlük 1.4-2.0 g/kg protein şart.";

                GunlukKalori = SecilenKilo * 38;
                ProteinGram = (int)(SecilenKilo * 2.0);
                KarbonhidratGram = (int)(SecilenKilo * 4.8);
                YagGram = (int)(SecilenKilo * 1.0);
                BeslenmeDetay = "Temiz kalori fazlası oluşturun. Her ana öğünde tavuk/yumurta gibi kaliteli protein ve zeytinyağı/kuruyemiş gibi sağlıklı yağlar tüketin.";
            }
            else if (SecilenKilo >= 65 && SecilenKilo < 75)
            {
                TavsiyeBaslik = "Kategori: Temiz Kilo Artışı (Lean Bulk) veya Koruma";
                TavsiyeDetay = "Amaç: Kas hacmi ve kuvvet artışı. Haftada 4 gün Upper/Lower veya PPL. Temel hareketler 3-5 x 6-10, yardımcı hareketler 3-4 x 8-15.";

                GunlukKalori = SecilenKilo * 34;
                ProteinGram = (int)(SecilenKilo * 2.2);
                KarbonhidratGram = (int)(SecilenKilo * 3.8);
                YagGram = (int)(SecilenKilo * 0.9);
                BeslenmeDetay = "Antrenman öncesi ve sonrası kaliteli karbonhidrat alımına dikkat edin. Paketli gıdalardan uzak durarak temiz kas inşasına odaklanın.";
            }
            else if (SecilenKilo >= 75 && SecilenKilo < 85)
            {
                TavsiyeBaslik = "Kategori: Form Koruma / Rekompozisyon";
                TavsiyeDetay = "Amaç: Yağ oranını dengelerken kas kütlesi kazanmak. 5 günlük bölünme (Göğüs/Omuz/Triceps, Sırt/Biceps, Bacak, Üst Vücut, Kardiyo). Temel bileşik hareketler ağırlıklı.";

                GunlukKalori = SecilenKilo * 30;
                ProteinGram = (int)(SecilenKilo * 2.2);
                KarbonhidratGram = (int)(SecilenKilo * 3.0);
                YagGram = (int)(SecilenKilo * 0.8);
                BeslenmeDetay = "Kalorinizi koruma seviyesinde tutun. Yüksek protein ve lifli yeşilliklerle kas kütlesini korurken yağ oranını kademeli azaltın.";
            }
            else if (SecilenKilo >= 85 && SecilenKilo < 100)
            {
                TavsiyeBaslik = "Kategori: Kilo Verme / Hafif Kalori Açığı (Definasyon)";
                TavsiyeDetay = "Amaç: Yağ yakarken kası korumak. Kuvvet (3-6 tekrar) ve Hipertrofi (6-15 tekrar) kombini. Hafif kalori açığı.";

                GunlukKalori = SecilenKilo * 25;
                ProteinGram = (int)(SecilenKilo * 2.4);
                KarbonhidratGram = (int)(SecilenKilo * 2.0);
                YagGram = (int)(SecilenKilo * 0.7);
                BeslenmeDetay = "300-500 kcal kalori açığı bırakın. Kas kaybını önlemek için proteini yüksek tutun, karbonhidratı sadece antrenman çevresine saklayın.";
            }
            else if (SecilenKilo >= 100 && SecilenKilo <= 120)
            {
                TavsiyeBaslik = "Kategori: Yoğun Yağ Yakımı ve Kalori Kontrolü";
                TavsiyeDetay = "Amaç: Sağlıklı yağ oranına inmek. Haftada 3-5 gün direnç antrenmanı + orta düzey kardiyo. Sürdürülebilir kalori açığı ve yüksek protein.";

                GunlukKalori = SecilenKilo * 22;
                ProteinGram = (int)(SecilenKilo * 2.3);
                KarbonhidratGram = (int)(SecilenKilo * 1.5);
                YagGram = (int)(SecilenKilo * 0.6);
                BeslenmeDetay = "Basit şeker ve unlu mamulleri kesin. Bol lif, yeşil sebze tüketin ve günde en az 3.5 litre su içmeyi hedefleyin.";
            }
            else
            {
                TavsiyeBaslik = "Hata";
                TavsiyeDetay = "Lütfen geçerli bir kilo seçiniz.";
            }
        }
    }
}
