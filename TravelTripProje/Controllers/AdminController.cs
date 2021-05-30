using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        [Authorize]
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [Authorize]
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Tarih = b.Tarih;
            blg.BlogImage = b.BlogImage;
            blg.Aciklama = b.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        [Authorize]
        public ActionResult YorumDuzenle(Yorumlar y)
        {
            var yorum = c.Yorumlars.Find(y.ID);
            yorum.KullaniciAdi = y.KullaniciAdi;
            yorum.Mail = y.Mail;
            yorum.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        [Authorize]
        public ActionResult Iletisim()
        {
            var iletisim = c.Iletisims.ToList();
            return View(iletisim);
        }

        [Authorize]
        public ActionResult IletisimGetir(int id)
        {
            var yr = c.Iletisims.Find(id);
            return View("IletisimGetir", yr);
        }
        [Authorize]
        public ActionResult IletisimDuzenle(Iletisim y)
        {
            var yorum = c.Iletisims.Find(y.ID);
            yorum.Mail = y.Mail;
            yorum.Yetkili = y.Yetkili;
            yorum.Telefon = y.Telefon;
            yorum.Fax = y.Fax;
            yorum.Konum = y.Konum;
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }


        [Authorize]
        public ActionResult Hakkimizda()
        {
            var hakkimizda = c.Hakkimizdas.ToList();
            return View(hakkimizda);
        }

        [Authorize]
        public ActionResult HakkimizdaGetir(int id)
        {
            var yr = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", yr);
        }
        [Authorize]
        public ActionResult HakkimizdaDuzenle(Hakkimizda y)
        {
            var yorum = c.Hakkimizdas.Find(y.ID);
            yorum.FotoUrl = y.FotoUrl;
            yorum.Aciklama = y.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

        [Authorize]
        public ActionResult KampRehber()
        {
            var kamp = c.Kamps.ToList();
            return View(kamp);
        }

        [Authorize]
        public ActionResult KampRehberGetir(int id)
        {
            var yr = c.Kamps.Find(id);
            return View("KampRehberGetir", yr);
        }
        [Authorize]
        public ActionResult KampRehberDuzenle(Kamp k)
        {
            var kamp = c.Kamps.Find(k.ID);
            kamp.Baslik1 = k.Baslik1;
            kamp.Baslik2 = k.Baslik2;
            kamp.Baslik3 = k.Baslik3;
            kamp.Aciklama1 = k.Aciklama1;
            kamp.Aciklama2 = k.Aciklama2;
            kamp.Aciklama3 = k.Aciklama3;
            kamp.Foto1 = k.Foto1;
            kamp.Foto2 = k.Foto2;
            c.SaveChanges();
            return RedirectToAction("KampRehber");
        }


        [Authorize]
        public ActionResult MuzeRehber()
        {
            var muze = c.Muzes.ToList();
            return View(muze);
        }

        [Authorize]
        public ActionResult MuzeRehberGetir(int id)
        {
            var yr = c.Muzes.Find(id);
            return View("MuzeRehberGetir", yr);
        }
        [Authorize]
        public ActionResult MuzeRehberDuzenle(Muze m)
        {
            var muze = c.Muzes.Find(m.ID);
            muze.Baslik1 = m.Baslik1;
            muze.Baslik2 = m.Baslik2;
            muze.Baslik3 = m.Baslik3;
            muze.Aciklama1 = m.Aciklama1;
            muze.Aciklama2 = m.Aciklama2;
            muze.Aciklama3 = m.Aciklama3;
            muze.Foto1 = m.Foto1;
            muze.Foto2 = m.Foto2;
            muze.Foto3 = m.Foto3;
            c.SaveChanges();
            return RedirectToAction("MuzeRehber");
        }


        [Authorize]
        public ActionResult DenizRehber()
        {
            var deniz = c.DenizTatils.ToList();
            return View(deniz);
        }

        [Authorize]
        public ActionResult DenizRehberGetir(int id)
        {
            var yr = c.DenizTatils.Find(id);
            return View("DenizRehberGetir", yr);
        }
        [Authorize]
        public ActionResult DenizRehberDuzenle(DenizTatil d)
        {
            var deniz = c.DenizTatils.Find(d.ID);
            deniz.Baslik1 = d.Baslik1;
            deniz.Baslik2 = d.Baslik2;
            deniz.Baslik3 = d.Baslik3;
            deniz.Aciklama1 = d.Aciklama1;
            deniz.Aciklama2 = d.Aciklama2;
            deniz.Aciklama3 = d.Aciklama3;
            deniz.Foto1 = d.Foto1;
            deniz.Foto2 = d.Foto2;
            deniz.Foto3 = d.Foto3;
            c.SaveChanges();
            return RedirectToAction("DenizRehber");
        }
    }
}