using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Book{
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public string Publisher { get; set; }
    public string Language { get; set; }
    public string Edition { get; set; }

    [DisplayName("publish Date")]
    [DataType(DataType.Date)]
    public DateTime PublishedDate { get; set; }
}