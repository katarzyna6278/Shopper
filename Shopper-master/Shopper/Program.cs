namespace Shopper
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ciało metody Main
            var tv = new Product("TV Samsung", "55' QLED", 2999.90m, "black");
            var keyboard = new Product("Klawiatura Logitech", "Klawiatura dla graczy", 199.90m, "silver");
            var desk = new Product("Biurko Ikea", "Biurko o szerokości 100 cm", 299.90m, "white");

            var shopProducts = new List<Product>() { tv, keyboard, desk };

            #region Kolekcje
            //Podstawowymi typami kolekcji są tablice oraz listy.

            //TABLICE - "komoda z szufladami"
            //Product[] products = new Product[] { tv, keyboard, desk };

            //Product[] products = new Product[3];
            //products[0] = tv;
            //products[1] = keyboard;
            //products[2] = desk;

            //products[1].Price = 179.90m;

            //LISTY - "worek"
            //List<Product> products = new List<Product>() { tv, keyboard, desk };
            //List<Product> products = new List<Product>();

            //products.Add(tv);           //[0]
            //products.Add(keyboard);     //[1]
            //products.Add(desk);         //[2]

            //products[1].Price = 190.90m;

            //products.Remove(keyboard);

            //products.Add(keyboard);
            #endregion

            var menu = new Menu();
            var cart = new Cart();

            ConsoleKeyInfo key;
            do
            {
                menu.Display();
                                     
                //Będziemy odpytywać użytkownika o prawidłowy klawisz tak długo, dopóki w końcu go znajdzie na swojej
                //klawiaturze. Aby to osiągnąć, użyjemy pętli.

                #region Pętle
                //Mamy 4 dostępne typy pętli:
                // - for
                // - foreach
                // - while
                // - do while

                //WHILE
                //int i = 0;
                //while (i < 2)
                //{
                //    Console.WriteLine("Obecna wartość zmiennej i to: " + i);
                //    i++;    // i = i + 1; inkrementacja
                //}

                //Console.ReadKey();

                //DO WHILE
                //i = 2;
                //do
                //{
                //    Console.WriteLine("Obecna wartość zmiennej i to: " + i);
                //    i++;
                //} while (i < 2);


                //FOR
                //for (int i = 0; i < 2; i++)
                //{
                //    Console.WriteLine("Obecna wartość zmiennej i to: " + i);
                //}

                //FOREACH
                //int[] ints = new int[] { 1, 2, 3, 4, 5, 6 };
                //foreach (var number in ints)
                //{
                //    Console.WriteLine("Obecna wartość zmiennej number to: " + number);
                //}
                #endregion

                key = Console.ReadKey();             

                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    do
                    {
                        Console.Clear();

                        Console.WriteLine("Ilość przedmiotów w koszyku: " + cart.Products.Count);
                        Console.WriteLine();

                        for (int i = 0; i < shopProducts.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ") " + shopProducts[i].Name + " " + shopProducts[i].Price);
                        }

                        #region To samo z foreach
                        //int i = 1;
                        //foreach (var shopProduct in shopProducts)
                        //{                   
                        //    Console.WriteLine("(" + i + ") " + shopProduct.Name + " " + shopProduct.Price);
                        //    i++;
                        //}
                        #endregion

                        Console.WriteLine();
                        Console.WriteLine("(X) Powrót");

                        key = Console.ReadKey();
                        Console.Clear();

                        if (key.Key == ConsoleKey.D1)
                        {
                            cart.Add(shopProducts[0]);
                            Console.WriteLine("Dodano "+ shopProducts[0].Name + " do koszyka.");
                            
                        }
                        else if (key.Key == ConsoleKey.D2)
                        {
                            cart.Add(shopProducts[1]);
                            Console.WriteLine("Dodano " + shopProducts[1].Name + " do koszyka.");
                        }
                        else if (key.Key == ConsoleKey.D3)
                        {
                            cart.Add(shopProducts[2]);
                            Console.WriteLine("Dodano " + shopProducts[2].Name + " do koszyka.");
                        }
                    } 
                    while (key.Key != ConsoleKey.X);               
                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    do 
                    {
                        Console.Clear();
                        if (cart.Products.Count <= 0)
                        {
                            Console.WriteLine("Twój koszyk jest pusty.");
                        }
                        else
                        {
                            Console.WriteLine("Zawartość koszyka:");
                            for (int i = 0; i < cart.Products.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {cart.Products[i].Name} | {cart.Products[i].Price}");

                            }
                            Console.WriteLine();
                            Console.WriteLine("Całkowita wartość koszyka: " + cart.Value);
                        }
                        
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij U aby usunąć produkt lub X aby wrócić do menu głównego.");
                        key = Console.ReadKey();

                        if (key.Key == ConsoleKey.U)
                        {
                            Console.WriteLine("Podaj numer produktu: ");
                            var productNumber = Console.ReadLine();
                            cart.Remove(Int32.Parse(productNumber));
                        }
                    } while (key.Key != ConsoleKey.X);

                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    Console.WriteLine("Dane kontaktowe:");
                    Console.WriteLine();
                    Console.WriteLine("Shopper Sp. z o.o.");
                    Console.WriteLine("ul. Polna 2");
                    Console.WriteLine("00-007 Owcza Górka");
                    Console.WriteLine("+48 987 456 321");
                    Console.WriteLine();
                    Console.WriteLine("Wciśnij dowolny klawisz aby wrócić do menu głównego.");
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.X)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wciśnięto błędny klawisz (" + key.Key + "). Naciśnij dowolny przycisk aby kontynuować.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (true);

            #endregion
        }
    }
}