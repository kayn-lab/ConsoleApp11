using ConsoleApp11;
using Metotlar;
using System.Text;

Musteri musteri1 = new Musteri();

musteri1.Name = "İbrahim";
musteri1.Surname = "....."

Musteri musteri2 =  new Musteri();
musteri2.Name = "Ahmet";
musteri2.Surname = ".....";
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

MusteriManager.Ekle2("İbrahim", "......", 19);
MusteriManager.Ekle2("Ahmet", "........", 49);








