using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace egitim
{
    public class Emlak
    {
        public Adres Adres;
        public long Id;
        public int M2;
        public DateTime IlanTarihi;
        public int Fiyat;
        public Musteri Musteri;

        public Emlak(Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri)
        {
            Adres = adres;
            Id = id;
            M2 = m2;
            IlanTarihi = ilanTarihi;
            Fiyat = fiyat;
            Musteri = musteri;
            Kontrol();
        }

        public void Kontrol()
        {
            if (M2 <= 0 || Fiyat <=0)
            {
                throw new Exception("Boş kısım bırakmayınız.");
            }

        }
    }

    public class Konut : Emlak
    {
        public string Cephe;
        public int BinaYasi;
        public int OdaSayisi;

        public Konut(string cephe, int binaYasi, int odaSayisi, Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri)
            : base(adres, id, m2, ilanTarihi, fiyat, musteri)
        {
            Cephe = cephe;
            BinaYasi = binaYasi;
            OdaSayisi = odaSayisi;
        }
        public void Kontrol()
        {
            if (Cephe == "" || Cephe == " ")
            {
                throw new Exception("Cephe boş bırakılamaz");
            }
            if (BinaYasi <= 0 || OdaSayisi <=0 )
            {
                throw new Exception("Bina yaşı ve Oda sayısı boş bırakılamaz");
            }
        }
    }

    public class KiralikEv : Konut
    {
        KiralikEmlakBilgisi kiralikBilgi;


        public KiralikEv(Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri, string cephe, int binaYasi, int odaSayisi) : base(cephe, binaYasi, odaSayisi, adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }
    }

    public class SatilikEv : Konut
    {


        public SatilikEv(Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri, string cephe, int binaYasi, int odaSayisi) : base(cephe, binaYasi, odaSayisi, adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }

    }

    public class SatilikVilla : Konut
    {
        public SatilikVilla(Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri, string cephe, int binaYasi, int odaSayisi) : base(cephe, binaYasi, odaSayisi, adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }
    }

    public class KiralikVilla : Konut
    {
        KiralikEmlakBilgisi kiralikBilgi;



        public KiralikVilla(Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri, string cephe, int binaYasi, int odaSayisi) : base(cephe, binaYasi, odaSayisi, adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }

    }
    public class Arsa : Emlak
    {


        public Arsa(ArsaBilgisi arsaBilgisi, Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri) : base(adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }


    }

    public class SatilikArsa : Arsa
    {
        public ArsaBilgisi arsaBilgisi;


        public SatilikArsa(ArsaBilgisi arsaBilgisi, Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri) : base(arsaBilgisi, adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }

    }

    public class KiralikArsa : Arsa
    {
        public KiralikEmlakBilgisi KiralikBilgi;

        public ArsaBilgisi arsaBilgisi;


        public KiralikArsa(ArsaBilgisi arsaBilgisi, KiralikEmlakBilgisi KiralikBilgi, Adres adres, long id, int m2, DateTime ilanTarihi, int fiyat, Musteri musteri) : base(arsaBilgisi, adres, id, m2, ilanTarihi, fiyat, musteri)
        {

        }

    }

    public class KiralikEmlakBilgisi
    {
        public int Deposito;
        public int Kefil;
        public string KontratSuresi;

        public KiralikEmlakBilgisi(int deposito, int kefil, string kontratSuresi)
        {
            Deposito = deposito;
            Kefil = kefil;
            KontratSuresi = kontratSuresi;
        }
    }
    public class ArsaBilgisi
    {
        public bool ImarliMi;
    }

    public class Adres
    {
        public Sehir Sehir;
        public Semt Semt;
        public string Cadde;
        public string Sokak;
        public int BinaNo;
        public int DaireNo;

        public Adres(Sehir sehir, Semt semt, string cadde, string sokak, int binaNo, int daireNo)
        {
            Sehir = sehir;
            Semt = semt;
            Cadde = cadde;
            Sokak = sokak;
            BinaNo = binaNo;
            DaireNo = daireNo;
            Kontrol();
        }
          

        public void Kontrol()
        {
            if (Cadde.Length <=0 || Sokak.Length <=0)
            {
                throw new Exception("Boş alan bırakmayınız.");
            }

        }
    }

    public class Semt
    {
        public int Kod;
        public string Ad;

        public Semt(int kod, string ad)
        {
            Kod = kod;
            Ad = ad;
        }
    }

    public class Sehir
    {
        public int PostaKodu;
        public int Kod;

        public Sehir(int postaKodu, int kod)
        {
            PostaKodu = postaKodu;
            Kod = kod;
        }

    }

    public class Musteri
    {
        public string Isim;
        public string SoyIsım;
        public IletisimBilgi Iletisim;

        public Musteri(string ısim, string soyIsım, IletisimBilgi ıletisim)
        {
            Isim = ısim;
            SoyIsım = soyIsım;
            Iletisim = ıletisim;

            Kontrol();
        }

        public void Kontrol()
        {
            if (Isim.Length <= 0 || SoyIsım.Length <= 0)
            {
                throw new Exception("Boş alan bırakmayınız.");
            }

        }

    }
    public class IletisimBilgi
    {
        public string TelNo1;
        public string TelNo2;
        public string EvNo;
        public string Email;

        public IletisimBilgi(string telNo1, string telNo2, string evNo, string email)
        {
            TelNo1 = telNo1;
            TelNo2 = telNo2;
            EvNo = evNo;
            Email = email;
        }
   
        public void Kontrol()
        {
            if (TelNo1.Length !=10 || TelNo2.Length !=10 || EvNo.Length !=10)
            {
                throw new Exception("Numaraları eksik yazmadığınızdan emin olun");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("Emaili boş bırakmayınız.");
            }
        }
    }
}
