using ConsoleApp11;
using Metotlar;
using System.Text;

Musteri musteri1 = new Musteri();

musteri1.Name = "İbrahim";
musteri1.Surname = "Delibaş";
musteri1.Old = 19;

Musteri musteri2 =  new Musteri();
musteri2.Name = "Ahmet";
musteri2.Surname = "Delibaş";
musteri2.Old = 49;

Musteri[] musteriler = new Musteri[] {musteri1,musteri2};

foreach (var musteri in musteriler)
{
    Console.WriteLine(musteri.Name);
    Console.WriteLine(musteri.Surname);
    Console.WriteLine(musteri.Old);




}

MusteriManager MusteriManager = new MusteriManager();
MusteriManager.Ekle(musteri1);
MusteriManager.Ekle(musteri2);

MusteriManager.Ekle2("İbrahim", "Delibaş", 19);
MusteriManager.Ekle2("Ahmet", "Delibaş", 49);








