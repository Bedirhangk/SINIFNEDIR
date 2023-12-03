using System.Reflection;

namespace SINIFNEDIR;

class Program
{
    static void Main(string[] args)
    {
        //söz Dizini
        //class SinifAdi
        //{
                //[erişim belirleyici] [Veri tipi] özlleik adı;
                //[Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi([parametre listesi])
                //{
                    //metot komutları
                //}
        //}

        //Erişim Berlirleyiciler
        // *Public -> Heryerden erişilebilir
        // *Private -> Sadece Buldunduğu sınıf içerisinde erişilebilir.
        // *Internal -> sadece Buluunduğu proje dosyasından erişilebilir.
        // *Protected -> Sadece tanımlandığı sınıfda ve o sınıfdan kalıtım, miras alan sınıflarda kullanılabilir.

        Calısan Calısan1 =new Calısan();
        Calısan1.Ad="Bedirhan";
        Calısan1.Soyad="Gökkaya";
        Calısan1.No=1;
        Calısan1.Departman="Yazılımcı";

        Calısan1.CalısanBilgileri();
        Console.WriteLine();

        Calısan Calısan2 =new Calısan();
        Calısan2.Ad="Selin";
        Calısan2.Soyad="Gürtürk";
        Calısan2.No=2;
        Calısan2.Departman="Genetik";
        
        Calısan2.CalısanBilgileri();

    }
}

class Calısan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalısanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: "+Ad);
        Console.WriteLine("Çalışan Soaydı: "+Soyad);
        Console.WriteLine("Çalışan No'su: "+No);
        Console.WriteLine("Çalışan Depratmanı: "+Departman);
    }
}
