internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        //T-> object türündedir.

        List<int>sayilistesi=new List<int>();

            sayilistesi.Add(23);
            sayilistesi.Add(20);
            sayilistesi.Add(4);
            sayilistesi.Add(92);
            sayilistesi.Add(34);
            sayilistesi.Add(56);

              List<string>renk=new List<string>();
              renk.Add("kırmızı");
              renk.Add("mavi");
              renk.Add("turuncu");
              renk.Add("yeşil");
              renk.Add("sarı");

              //count;
              Console.WriteLine(renk.Count());
              Console.WriteLine(sayilistesi.Count());

                //Foreaach ve List Foreach ile elemanlara erişim.
              foreach (var item in sayilistesi)
              {
                Console.WriteLine(item);
              }

             Console.WriteLine("-----------------------");
               
               foreach (var item in renk)
              {
                Console.WriteLine(item);
              }
             Console.WriteLine("-----------------------");

              sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
              renk.ForEach(renk => Console.WriteLine(renk));

              Console.WriteLine("-----------------------");


              //Listeden eleman çıkarma
              sayilistesi.Remove(4);
              renk.Remove("yeşil");

              sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
              renk.ForEach(renk => Console.WriteLine(renk));
              //RemoveAt
              sayilistesi.RemoveAt(0);//index'e göre eleman çıkarma
              renk.RemoveAt(1);//index'e göre eleman çıkarma
              sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
              renk.ForEach(renk => Console.WriteLine(renk));

              //List içerisinde arama
              
              if(sayilistesi.Contains(20))
              Console.WriteLine("20 Liste içerisinde bulundu.");

              //Eleman ile index'e erişme
              Console.WriteLine(renk.BinarySearch("sarı"));

            Console.WriteLine("-----------------------");


              //Diziyi List'e çevirmek
              string [] hayvanlar={ "kedi","köpek","kuş"};

              List<string> hayvanListesi=new List<string>(hayvanlar);
              hayvanListesi.ForEach(hayvan =>Console.WriteLine(hayvan));
                Console.WriteLine("-----------------------");

              //Listeyi Temizleme
              hayvanListesi.Clear();
              hayvanListesi.ForEach(hayvan =>Console.WriteLine(hayvan));


              //List içerisinde nesne tutma
              List<Kullanıcılar> kullanıcı_listesi=new List<Kullanıcılar>();
              
              Kullanıcılar kullanicilar= new Kullanıcılar();
              kullanicilar.Isim="Ayşe";
              kullanicilar.Soyisim="Yılmaz";
              kullanicilar.Yas=25;

            Kullanıcılar kullanicilar2= new Kullanıcılar();
              kullanicilar2.Isim="özcan";
              kullanicilar2.Soyisim="Korkmaz";
              kullanicilar2.Yas=34;

            kullanıcı_listesi.Add(kullanicilar);
            kullanıcı_listesi.Add(kullanicilar2);

            List<Kullanıcılar> yeniliste=new List<Kullanıcılar>( );
            
            yeniliste.Add(new Kullanıcılar()
            {
                Isim="hakan",
                Soyisim="Sönmez",
                Yas=27


            });

            foreach (var kullanıcı in kullanıcı_listesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:"+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:"+kullanıcı.Yas);
                
            };






              

              


    }


    }
    public class Kullanıcılar
    {
       private string isim;
        private string soyisim;

        private int yas;

        public  string Isim {get;set;}
        public  string Soyisim {get;set;}

        public  int Yas {get;set;}




    }
