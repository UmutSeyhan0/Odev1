using egitim;

public class Program
{
    static void Main(string[] args)
    {


        IletisimBilgi iletisim = new IletisimBilgi("0", "1", "2", "a@gmailcom");
        Musteri musteri = new Musteri("Umut", "Seyhan", iletisim);
        List<Musteri> musterilist = new List<Musteri>();
        musterilist.Add(musteri);

        Konut konut = new Konut("Doğu", 3, 5, new Adres(new Sehir(1900, 5), new Semt(98, "Buhara"), "Fatih", "Ahcılar", 15, 29), 98,154, DateTime.Now, 139000, new Musteri("Umut", "Seyhan", new IletisimBilgi("55553", "1113331", "999", "a@gmail.com")));

        List<Konut> konutlist = new List<Konut>();
        konutlist.Add(konut);

        foreach (Konut m in konutlist)
        {
            Console.WriteLine($"Konut Bilgileri\nAdres Bilgisi:\nPosta Kodu:{m.Adres.Sehir.PostaKodu} Semt:{m.Adres.Semt.Ad} Cadde:{m.Adres.Cadde} Sokak:{m.Adres.Sokak} Bina no :{m.Adres.BinaNo} \nKonut Özellikleri:\nCephe:{m.Cephe} Bina Yaşı:{m.BinaYasi} Oda Sayısı:{m.OdaSayisi}\nMüşteri Bilgileri:\nİsim:{m.Musteri.Isim} \nSoyisim:{m.Musteri.SoyIsım} \nTel1:{m.Musteri.Iletisim.TelNo1} \nMail:{m.Musteri.Iletisim.Email} ");
        }
    }
}