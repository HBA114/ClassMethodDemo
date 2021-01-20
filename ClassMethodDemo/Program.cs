using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                    // Musteri Ekleme Silme ve Lİsteleme islemlerini yapan konsol uygulaması.
namespace ClassMethodDemo
{
    class Program : ClientManager
    {
        static void Main(string[] args)
        {
            ClientManager CM = new ClientManager();

            string secim = "0";
            int id;
            string name, surname;
            while(secim != "4")
            {
                Console.Clear();
                Console.WriteLine("1) Ekle 2) Listele 3) Sil 4) Cikis\n");
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Eklenecek Musterinin Adini giriniz...\n");
                        name = Console.ReadLine();
                        Console.WriteLine("Eklenecek Musterinin Soyadini giriniz...\n");
                        surname = Console.ReadLine();
                        Console.WriteLine("Eklenecek Musterinin Id'sini giriniz...\n");
                        id = Convert.ToInt32(Console.ReadLine());
                        CM.Add(name, surname, id);
                        break;

                    case "2":
                        CM.List();
                        Console.WriteLine("\nMenuye donmek icin Enter'a basiniz...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Silinecek Musterinin Id'sini giriniz...");
                        id = Convert.ToInt32(Console.ReadLine());
                        CM.Delete(id);
                        break;

                    case "4":
                        Console.WriteLine("Cıkmak icin Enter'a basiniz...");
                        break;
                    default:
                        Console.WriteLine("\nHatali islem secimi!! Menuye donmek icin Enter'a basiniz.");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
