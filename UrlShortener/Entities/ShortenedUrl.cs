namespace UrlShortener.Entities;

public class ShortenedUrl
{
    public Guid Id { get; set; }

    public string LongUrl { get; set; } = string.Empty;

    public string ShortUrl { get; set; } = string.Empty; // должен быть привязен к коткретному пользователю

    public string Code { get; set; } = string.Empty;
    
    public DateTime CreatedOnUtc { get; set; }

}