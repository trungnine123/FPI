    namespace FPI.Models
    {
        public class NewsItem
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime PublishedDate { get; set; }
            public string ImageUrl { get; set; }
        }
    }