namespace proje2_ToDo
{
    class Choice
    {
        static List<Kart> todo = new List<Kart>(){};
        static List<Kart> progress = new List<Kart>(){};
        static List<Kart> done = new List<Kart>(){};
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
            
            
            
        }



        ///<summary>
        /// Kart template'i ekrana yazdırılır.
        ///</summary>
        ///<returns>void, sadece ekrana yazdırır</returns>
        private static void PrintTemplate(object Kart)
        {
            /*Console.WriteLine($@"Başlık: {}
            \nİçerik: {}");*/
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
        private static void FailProtocol()
        {
            
        }


    }
}