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
*******************************************
(1) Board Listelemek
(2) Board'a Kart Eklemek
(3) Board'dan Kart Değiştirmek
(4) Board'dan Kart Silmek
(5) Kart Taşımak
(0) Uygulamadan Çık");
                
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
                        Choice.KartPrint();
                        break;
                    }
                    
                    case 2:
                    {
                        Console.Clear();
                        Choice.KartEkle();
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
                        Choice.KartDelete();
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