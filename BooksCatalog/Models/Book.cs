namespace BooksCatalog.Models {
    public class Book {
        public int Id { get; set; }
        public BookCategory Category { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public bool InStock { get; set; }
    }
}