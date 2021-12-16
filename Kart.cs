namespace proje2_ToDo
{
    class Kart
    {
        public string Title { get; set; }
        public string Context { get; set; }
        private string Name { get; }
        private int Size { get; }


        public Kart(string title, string context, string name, int size)
        {
            this.Title = title;
            this.Context = context;
            this.Name = name;
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