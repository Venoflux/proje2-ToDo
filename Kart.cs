namespace proje2_ToDo
{
    class Kart
    {
        public string Title;
        public string Context;
        private int Id;
        private int Size;


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
            
            Console.WriteLine($@"Başlık: {Title}
İçerik: {Context}
Atanan Kişi: {name}
Büyükşük: {size}");
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