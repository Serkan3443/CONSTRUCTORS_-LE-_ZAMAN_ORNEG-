namespace CONSTRUCTORS_ZAMAN_ORNEGİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Time zaman=new Time(3800);
            Console.WriteLine(zaman.ZamaniHesapla());

          zaman=new Time("23:59:59");
            Console.WriteLine(zaman.SureyiHesapla() + " saniye. ");

        }
    }
}