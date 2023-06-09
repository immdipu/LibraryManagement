using Microsoft.AspNetCore.Mvc;

public class BooksController:Controller{

   static List<Book> books= new List<Book>(){new Book{
    Id=1, 
    Title="chemistry",
    Author="stephen", 
    Edition="III", 
    Language="En", 
    Price=456.5, 
    PublishedDate=DateTime.Now,
     Publisher="LPE"}};
    public IActionResult Index(){
        return View(books);
    }
    
    public IActionResult Addbook(){
        return View();
    }
    [HttpPost]
    public IActionResult Addbook(Book book){
        books.Add(book);
        return RedirectToAction("Index");
    }

}