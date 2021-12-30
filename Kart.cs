namespace proje2_ToDo
{
    class Kart
    {
        public string Title {get;set;}
        public string Context {get;set;}
        public int Id {get;set;}
        public int Size {get;set;}


        public Kart(string title, string context, int id, int size)
        {
            this.Title = title;
            this.Context = context;
            this.Id = id;
            this.Size = size;
        }

        public void KartBilgileri(Dictionary<int, string> my_dict)
        {
            string name = my_dict.GetValueOrDefault(Id);
            string size = Enum.GetName(typeof(SizeTypes), Size);
            
            Console.WriteLine($@"Başlık     : {Title}
İçerik      : {Context}
Atanan Kişi : {name}
Büyüklük    : {size}");
        }
    }

    public enum SizeTypes
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
}