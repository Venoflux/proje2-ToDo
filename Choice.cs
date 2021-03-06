namespace proje2_ToDo
{
    class Choice
    {
        static List<Kart> todo = new List<Kart>(){
            new Kart("Cleaning", "Floor needs to be cleaned", 123, 1),
        };
        static List<Kart> progress = new List<Kart>(){
            new Kart("Cleaning", "Floor needs to be cleaned", 321, 2),
        };
        static List<Kart> done = new List<Kart>(){
            new Kart("Cleaning", "Floor needs to be cleaned", 523, 3),
        };
        static Dictionary<int, string> worker_dict = new Dictionary<int, string>(){
            {123, "Ahmet Baran"},
            {321, "Rutkay Kuzgun"},
            {523, "Esra Siler"}
        };

        public static void KartEkle()
        {
            Console.WriteLine("Başlık Giriniz                                 : ");
            string title = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz                                 :");
            string context = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int size = 0;
            while (size < 1 || size > 5)
                 while (!Int32.TryParse(Console.ReadLine(), out size)){}
            
            Console.WriteLine("Kişi Seçiniz                                   :");
            int id;
            while (!Int32.TryParse(Console.ReadLine(), out id)){}
            if (IsMember(id, worker_dict))
            {
                Kart yeniKart = new Kart(title, context, id, size);
                todo.Add(yeniKart);
                Console.WriteLine("Kart başarıyla eklendi!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static void KartUpdate()
        {
            Console.WriteLine("Güncellemek İstediğiniz Kart'ın Başlığı :");
            string title = Console.ReadLine();
            int search_index;
            switch (Choice.ListeBulucu(title))
            {
                case 1:
                {
                    search_index = KartBulucu(title, todo);
                    KartUpdater(search_index, todo, worker_dict);
                    Console.WriteLine("Başarılı...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:
                {
                    search_index = KartBulucu(title, progress);
                    KartUpdater(search_index, progress, worker_dict);
                    Console.WriteLine("Başarılı...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 3:
                {
                    search_index = KartBulucu(title, done);
                    KartUpdater(search_index, done, worker_dict);
                    Console.WriteLine("Başarılı...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case -1:
                {
                    Console.WriteLine(@" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim 
yapınız.");
                    Console.WriteLine("* İşkemi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    // Özelliği durdur veya yeniden dene programını buraya ekle.
                    int choice;
                    while (!Int32.TryParse(Console.ReadLine(), out choice)){}

                    if (choice == 2)
                        {
                            Console.Clear();
                            KartUpdate();
                            break;
                        }
                        
                    else if (choice == 1)
                        {
                            Console.Clear();
                            break;
                        }

                    else
                        {
                            Console.Clear();
                            break;
                        }    
                }
                
                default:
                    break;
            }   
        }

        public static void KartDelete()
        {
            Console.WriteLine(@"Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.
 Lütfen kart başlığını yazınız:  ");
            string title = Console.ReadLine();
            int search_index;
            switch (Choice.ListeBulucu(title))
            {
                case 1:
                {
                    search_index = KartBulucu(title, todo);
                    todo.RemoveAt(search_index);
                    Console.WriteLine("Kart başarıyla silinmiştir.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:
                {
                    search_index = KartBulucu(title, progress);
                    progress.RemoveAt(search_index);
                    Console.WriteLine("Kart başarıyla silinmiştir.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 3:
                {
                    search_index = KartBulucu(title, done);
                    done.RemoveAt(search_index);
                    Console.WriteLine("Kart başarıyla silinmiştir.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case -1:
                {
                    Console.WriteLine(@" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim 
yapınız.");
                    Console.WriteLine("* İşkemi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    // Özelliği durdur veya yeniden dene programını buraya ekle.
                    int choice;
                    while (!Int32.TryParse(Console.ReadLine(), out choice)){}

                    if (choice == 2)
                        {
                            Console.Clear();
                            KartDelete();
                            break;
                        }
                        
                    else if (choice == 1)
                        {
                            Console.Clear();
                            break;
                        }

                    else
                        {
                            Console.Clear();
                            break;
                        }
                }
                
                default:
                    break;
            }   
        }

        public static void KartMove()
        {
            Console.WriteLine(@"Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.
Lütfen kart başlığını yazınız:  ");
            string title = Console.ReadLine();
            int search_index;
            switch (Choice.ListeBulucu(title))
            {
                case 1:
                {
                    search_index = KartBulucu(title, todo);
                    KartMover(search_index, "TODO", todo, worker_dict);
                    Console.WriteLine("Kart başarıyla taşınmıştır.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:
                {
                    search_index = KartBulucu(title, progress);
                    KartMover(search_index, "IN PROGRESS", progress, worker_dict);
                    Console.WriteLine("Kart başarıyla taşınmıştır.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 3:
                {
                    search_index = KartBulucu(title, done);
                    KartMover(search_index, "DONE", done, worker_dict);
                    Console.WriteLine("Kart başarıyla taşınmıştır.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case -1:
                {
                    Console.WriteLine(@" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim 
yapınız.");
                    Console.WriteLine("* İşkemi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    // Özelliği durdur veya yeniden dene programını buraya ekle.
                    int choice;
                    while (!Int32.TryParse(Console.ReadLine(), out choice)){}

                    if (choice == 2)
                        {
                            Console.Clear();
                            KartMove();
                            break;
                        }
                        
                    else if (choice == 1)
                        {
                            Console.Clear();
                            break;
                        }

                    else
                        {
                            Console.Clear();
                            break;
                        }
                }
                
                default:
                    break;
            }
        }

        public static void KartPrint()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (todo.Count != 0)
            {
                foreach (var item in todo)
                {
                    item.KartBilgileri(worker_dict);
                    Console.WriteLine("-");
                }
            }
            else
                Console.WriteLine("~ BOŞ ~");

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("************************");
            if (progress.Count != 0)
            {
                foreach (var item in progress)
                {
                    item.KartBilgileri(worker_dict);
                    Console.WriteLine("-");
                }
            }
            else
                Console.WriteLine("~ BOŞ ~");

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("************************");
            if (done.Count != 0)
            {
                foreach (var item in done)
                {
                    item.KartBilgileri(worker_dict);
                    Console.WriteLine("-");
                }
            }
            else
                Console.WriteLine("~ BOŞ ~");

            Console.ReadKey();
            Console.Clear();
        }


        ///<summary>
        /// Girilen id input'u dictionary de varmı kontrol eder.
        ///</summary>
        ///<returns>bool</returns>
        private static bool IsMember(int id, Dictionary<int, string> my_dict)
        {
            foreach (int member in my_dict.Keys)
                if (member == id)
                    return true;
            return false;
        }

        ///<summary>
        /// İçinde Kart objesi olan bir listenin Title indexini verir.
        ///</summary>
        ///<returns>int index, bulamaz ise -1</returns>
        private static int KartBulucu(string input, List<Kart> myList)
        {
            return myList.FindIndex(x => x.Title == input);
        }

        ///<summary>
        /// Her Liste içini kontrol ederek aramanın hangi listede olduğunu verir.
        ///</summary>
        ///<returns>int 1-3, bulamaz ise -1</returns>
        private static int ListeBulucu(string input)
        {
            int index = KartBulucu(input, todo);
            if(index != -1)
                return 1;
            else{
                    index = KartBulucu(input, progress);
                    if(index != -1)
                        return 2;
                    else{
                        index = KartBulucu(input, done);
                        if(index != -1)
                            return 3;
                        else
                            return -1;
                    }
                }
        }

        private static void KartUpdater(int index, List<Kart> myList, Dictionary<int, string> my_dict)
        {
            Console.WriteLine("Lütfen aşağıdaki Kart'ın hangi bilgisini değiştirmek istediğinizi seçiniz: ");
            myList[index].KartBilgileri(my_dict);
            Console.WriteLine(@"
Başlık      (1)
İçerik      (2)
Atanan Kişi (3)
Büyüklük    (4)");

            int choice;
            while (!Int32.TryParse(Console.ReadLine(), out choice)){}

            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("Yeni başlığı giriniz.");
                    string new_title = Console.ReadLine();
                    myList[index].Title = new_title;
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Yeni içeriği giriniz.");
                    string new_context = Console.ReadLine();
                    myList[index].Context = new_context;
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Yeni atanan kişinin id sini giriniz.");

                    int new_id;
                    while (!Int32.TryParse(Console.ReadLine(), out new_id)){}

                    if (IsMember(new_id, worker_dict))
                        myList[index].Id = new_id;
                    
                    else
                    {
                        Console.WriteLine("Girdiğiniz id veri tabanına bulunmamaktadır.");
                        Console.ReadKey();
                        Console.Clear();
                    }       
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Yeni büyüklüğü seçiniz.");
                    Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");

                    int new_size = 0;
                    while (new_size < 1 || new_size > 5)
                        while (!Int32.TryParse(Console.ReadLine(), out new_size)){}

                    myList[index].Size = new_size;
                    break;
                }
                
                default:
                {
                    Console.WriteLine("Yanlış veri girdiniz!");
                    Console.ReadKey();
                    break;
                }
            }
        }
        private static void KartMover(int index, string line, List<Kart> fromList, Dictionary<int, string> my_dict)
        {
            Console.WriteLine(@"Bulunan Kart Bilgileri:
**************************************");
            fromList[index].KartBilgileri(my_dict);
            Console.WriteLine($"Line       :");
            Console.WriteLine(@"
Lütfen taşımak istediğiniz Line'ı seçiniz:
(1) TODO
(2) IN PROGRESS
(3) DONE");

            int choice;
            while (!Int32.TryParse(Console.ReadLine(), out choice)){}

            switch (choice)
            {
                case 1:
                {
                    todo.Add(fromList[index]);
                    fromList.RemoveAt(index);
                    break;
                }
                case 2:
                {
                    progress.Add(fromList[index]);
                    fromList.RemoveAt(index);
                    break;
                }
                case 3:
                {
                    done.Add(fromList[index]);
                    fromList.RemoveAt(index);
                    break;
                }
                default:
                {
                    Console.WriteLine("Yanlış veri girdiniz!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}