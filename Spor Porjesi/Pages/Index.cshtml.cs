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

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (SecilenKilo >= 45 && SecilenKilo < 55)
            {
                TavsiyeBaslik = "Kategori: Yüksek Kalori İhtiyacı / Hacim (Bulk)";
                TavsiyeDetay = "Amaç: Vücudu antrenmana alıştırmak, temel kuvvet ve hareket tekniğini geliştirmek. Haftada 3 gün Full-Body, 2-3 set x 10-15 tekrar. Squat, lunge, bench press, row, lat pulldown.";
            }
            else if (SecilenKilo >= 55 && SecilenKilo < 65)
            {
                TavsiyeBaslik = "Kategori: Kilo Alma / Kas Kazanımı";
                TavsiyeDetay = "Amaç: Kas kütlesini artırmak. Haftada 3-4 gün Upper/Lower veya Full-Body. Temel hareketlerde 3-4 x 8-12. Günlük 1.4-2.0 g/kg protein şart.";
            }
            else if (SecilenKilo >= 65 && SecilenKilo < 75)
            {
                TavsiyeBaslik = "Kategori: Temiz Kilo Artışı (Lean Bulk) veya Koruma";
                TavsiyeDetay = "Amaç: Kas hacmi ve kuvvet artışı. Haftada 4 gün Upper/Lower veya PPL. Temel hareketler 3-5 x 6-10, yardımcı hareketler 3-4 x 8-15.";
            }
            else if (SecilenKilo >= 75 && SecilenKilo < 85)
            {
                TavsiyeBaslik = "Kategori: Form Koruma / Rekompozisyon";
                TavsiyeDetay = "Amaç: Yağ oranını dengelerken kas kütlesi kazanmak. 5 günlük bölünme (Göğüs/Omuz/Triceps, Sırt/Biceps, Bacak, Üst Vücut, Kardiyo). Temel bileşik hareketler ağırlıklı.";
            }
            else if (SecilenKilo >= 85 && SecilenKilo < 100)
            {
                TavsiyeBaslik = "Kategori: Kilo Verme / Hafif Kalori Açığı (Definasyon)";
                TavsiyeDetay = "Amaç: Yağ yakarken kası korumak. Kuvvet (3-6 tekrar) ve Hipertrofi (6-15 tekrar) kombini. Hafif kalori açığı.";
            }
            else if (SecilenKilo >= 100 && SecilenKilo <= 120)
            {
                TavsiyeBaslik = "Kategori: Yoğun Yağ Yakımı ve Kalori Kontrolü";
                TavsiyeDetay = "Amaç: Sağlıklı yağ oranına inmek. Haftada 3-5 gün direnç antrenmanı + orta düzey kardiyo. Sürdürülebilir kalori açığı ve yüksek protein.";
            }
            else
            {
                TavsiyeBaslik = "Hata";
                TavsiyeDetay = "Lütfen geçerli bir kilo seçiniz.";
            }
        }
    }
}