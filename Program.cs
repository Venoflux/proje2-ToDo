namespace proje2_ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = true;

            while (power)
            {
                 Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçiniz :)
                 \n*******************************************
                 \n(1) Board Listelemek
                 \n(2) Board'a Kart Eklemek
                 \n(3) Board'dan Kart Değiştirmek
                 \n(4) Board'dan Kart Silmek
                 \n(5) Kart Taşımak
                 \n(0) Uygulamadan Çık");
                
                int choice;
                while (!Int32.TryParse(Console.ReadLine(), out choice)){}

                switch (choice)
                {
                    case 0:
                    {
                        power = false;
                        break;
                    }

                    case 1:
                    {
                        Console.Clear();
                        break;
                    }
                    
                    case 2:
                    {
                        Console.Clear();
                        break;
                    }

                    case 3:
                    {
                        Console.Clear();
                        break;
                    }

                    case 4:
                    {
                        Console.Clear();
                        break;
                    } 

                    case 5:
                    {
                        Console.Clear();
                        break;
                    }

                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("Olan seçeneklerin dışında bir veri giridniz. \n");
                        break;
                    }
                }
            }
        }
    }
}