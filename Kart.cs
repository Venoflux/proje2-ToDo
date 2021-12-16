namespace proje2_ToDo
{
    class Kart
    {
        public string Title { get; set; }
        public string Context { get; set; }
        private int Id { get; }
        private int Size { get; }


        public Kart(string title, string context, int id, int size)
        {
            this.Title = title;
            this.Context = context;
            this.Id = id;
            this.Size = size;
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