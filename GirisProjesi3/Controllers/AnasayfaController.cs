using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GirisProjesi3.Models;
using Microsoft.AspNetCore.Mvc;

namespace GirisProjesi3.Controllers
{
    public class AnasayfaController : Controller
    {
        public ViewResult Icerik()
        {
            Urun urun = new Urun
            {
                UrunID = 1,
                Isim = "Mazejik",
                Aciklama = "Kaliteli ağrı kesici",
                Kategori = "Ağrı kesiciler",
                Fiyat = 12.99m
            };
            Random rastgeleSayi= new Random();          
            ViewBag.MazejikStok = rastgeleSayi.Next(0, 7);

            ViewBag.OrnekVeriCantasi = "Ürünlerimiz henüz geldi.";
            ViewData["Yeniİlaç"] = urun;
            return View(urun);
        }
        public ViewResult GenisIcerik()
        {
            //coleksiyon başlatıcılarla hızlıca nesne koleksiyonu oluşturalım.
            Urun[] urunlerimiz = /*new Urun[]*/ { new Urun
                {
                    UrunID = 1,
                    Isim = "Mazejik",
                    Aciklama = "Kaliteli ağrı kesici",
                    Kategori = "Ağrı kesiciler",
                    Fiyat = 12.99m
                },new Urun
                {
                    UrunID = 1,
                    Isim = "Asprin",
                    Aciklama = "Sıradan ağrı kesici",
                    Kategori = "Ağrı kesiciler",
                    Fiyat = 5.99m
                },new Urun
                {
                    UrunID = 1,
                    Isim = "Apranax",
                    Aciklama = "Güçlü ağrılar için",
                    Kategori = "Ağrı kesiciler",
                    Fiyat = 48.99m
                }
            };

            Random rastgeleSayi = new Random();
            for (int i = 0; i < urunlerimiz.Count(); i++)
            {
                ViewData[urunlerimiz[i].Isim + ".Stok"] = rastgeleSayi.Next(0, 8);
            }
          
            return View(urunlerimiz);
        }
    }
}