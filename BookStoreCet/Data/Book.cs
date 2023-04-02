using System.ComponentModel.DataAnnotations;

namespace BookStoreCet.Data;

public class Book
{
    [Required] 
  
    public int Id { get; set; }
    public string Name { get; set; }
    public Decimal Price { get; set; } //float ve double yaklaşık değer tutar
    public int PageCount { get; set; }
    public DateTime PublishDate { get; set; }
    public int PublisherId { get; set; }
    public virtual Publisher Publisher { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
public class Publisher
{
    public int Id { get; set; }
   
    public string Name { get; set; }

    public virtual List<Book>? Books { get; set; } = new List<Book>();
}
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual List<Book>? Books { get; set; } = new List<Book>();

}