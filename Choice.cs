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
            {523, "Baran Siler"}
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

        private static void FailProtocol()
        {

        }
    }
}