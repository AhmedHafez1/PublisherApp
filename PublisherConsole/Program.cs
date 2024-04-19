
using PublisherData;
using PublisherDomain;

using PubContext _context = new(); // existing database

var cover = _context.Covers.Find(2);
var book = new Book { AuthorId = 3, Title = "Angular 17", PublishDate = new DateOnly(2021, 6, 7), BasePrice = 7 };
var author = new Author { FirstName = "Sarah", LastName = "Mohamed" };
book.Cover = cover;
book.Author = author;


_context.Books.Add(book);

_context.SaveChanges();
