using Microsoft.AspNetCore.Mvc;
using FPI.Models;
using System.Collections.Generic;

public class NewsController : Controller
{
    public IActionResult Index()
    {
        // This is just sample data. Replace it with your actual data source.
        var newsItems = new List<NewsItem>
        {
            new NewsItem { Id = 1, Title = "FPI Opens New Campus", Content = "The new campus features state-of-the-art facilities.", PublishedDate = DateTime.Now, ImageUrl = "https://media.istockphoto.com/id/173598452/photo/university-in-autumn.jpg?s=612x612&w=0&k=20&c=jQqpZuTZ6qXIfWqnCW5nqlExJZO0PO47L-ZiaE8jIk0=" },
            // Add more news items here
        };

        return View(newsItems);
    }
}