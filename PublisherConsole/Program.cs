
using PublisherData;
using PublisherDomain;

PubContext _context = new(); //existing database

//InsertNewAuthorWithNewBook();
InsertBookForExistingAuthor();

void InsertNewAuthorWithNewBook()
{
    var author = new Author { FirstName = "Lynda", LastName = "Rutledge" };
    author.Books.Add(new Book
    {
        Title = "West With Giraffes",
        PublishDate = new DateOnly(2021, 2, 1)
    });
    _context.Authors.Add(author);
    _context.SaveChanges();
}

void InsertBookForExistingAuthor()
{
    Book book = new Book { Title = "Book3", PublishDate = new DateOnly(2016, 3, 7), BasePrice = 10, AuthorId = 3 };
    _context.Books.Add(book);
    _context.SaveChanges();
}