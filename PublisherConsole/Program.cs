
using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

PubContext _context = new(); // existing database

//GetAuthorsWithBooks();
//GetProjectedAuthors();

GetBooksForAuthorAlreadyInMemory();

void GetAuthorsWithBooks()
{
    var authors = _context.Authors.Include(a => a.Books).ToList();
    authors.ForEach(a =>
    {
        Console.WriteLine($"{a.LastName} ({a.Books.Count})");
    });
}

void GetProjectedAuthors()
{
    var authors = _context.Authors.Select(a => new { Name = $"{a.FirstName} {a.LastName}", a.Books }).ToList();

    authors.ForEach(a =>
    {
        Console.WriteLine($"{a.Name} ({a.Books.Count})");
    });

    var debugView = _context.ChangeTracker.DebugView.ShortView;
}

void GetBooksForAuthorAlreadyInMemory()
{
    var author = _context.Authors.FirstOrDefault(a => a.FirstName.StartsWith("R"));

    if (author != null)
        _context.Entry(author).Collection(a => a.Books).Load();
}