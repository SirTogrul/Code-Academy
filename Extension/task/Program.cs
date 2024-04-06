using System.Xml.Serialization;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Store store = new Store();
            Person person = new Person();
            do
            {
                Console.WriteLine("1. Mehsul elave et");
                Console.WriteLine("2. Mehsul sil");
                Console.WriteLine("3. Mehsula bax");
                Console.WriteLine("4. Type'a gore mehsullara bax");
                Console.WriteLine("5. Ada gore mehsullara bax");
                Console.WriteLine("0. Proqramdan cix");
                Console.Write("Seciminizi edin: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Mehsul adi: ");
                        string name = Console.ReadLine();
                        Console.Write("Mehsul tipi: ");
                        string type = Console.ReadLine();
                        Console.Write("Mehsul qiymeti: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Mehsul sayi: ");
                        int count =Convert.ToInt32(Console.ReadLine());

                        Product newProduct = new Product { Name = name, Type = type, Price = price, Count = count };
                        store.AddProduct(newProduct);
                        Console.WriteLine("Mehsul elave edildi.");
                        break;

                    case "2":
                        Console.Write("Silmek istediyiniz mehsulun no'su: ");
                        int productNo =Convert.ToInt32(Console.ReadLine());
                        store.RemoveProductByNo(productNo);
                        Console.WriteLine("Mehsul silindi.");
                        break;

                    case "3":
                        Console.Write("Baxmaq istediyiniz mehsulun no'su: ");
                        int ShowNo = Convert.ToInt32(Console.ReadLine());
                        Product ShowProduct = store.GetProduct(ShowNo);
                        if (ShowProduct != null)
                            Console.WriteLine(ShowProduct);
                        else
                            Console.WriteLine("Mehsul tapilmadi.");
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.Write("Baxmaq istediyiniz mehsullarin type'i: ");
                        string ShowType = Console.ReadLine();
                        Product[] typeFilterProducts = store.FilterProductsByType(ShowType);
                        if (typeFilterProducts.Length > 0)
                        {
                            for (int i = 0; i < typeFilterProducts.Length; i++)
                            {
                                Console.WriteLine(typeFilterProducts[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Type'a uygun mehsul tapilmadi.");
                        }
                        Console.WriteLine();
                        break;

                    case "5":
                        Console.Write("Baxmaq istediyiniz mehsullarin adi: ");
                        string ShowName = Console.ReadLine();
                        Product[] nameFilterProducts = store.FilterProductByName(ShowName);
                        if (nameFilterProducts.Length > 0)
                        {
                            for (int i = 0; i < nameFilterProducts.Length; i++)
                            {
                                Console.WriteLine(nameFilterProducts[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ad'a uygun mehsul tapilmadi.");
                        }
                        Console.WriteLine();
                        break;

                    case "0":
                        Console.WriteLine("Proqramdan cixildi.");
                        return;

                    default:
                        Console.WriteLine("Yanlis secim! Zehmet olmasa dogru secim edin.");
                        break;
                }
            } while (false);
        }
    }
    
}