using Microsoft.AspNetCore.Mvc;

public class BooksController:Controller{
    public IActionResult Index(){

List<Book> books= new List<Book>();

books.Add(new Book{Id=1, Title="chemistry",Author="stephen", Edition="III", Language="En", Price=456.5, PublishedDate=DateTime.Now, Publisher="LPE"});

        return View(books);
    }
    
}