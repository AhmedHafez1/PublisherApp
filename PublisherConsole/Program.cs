
using PublisherData;
using PublisherDomain;

using PubContext _context = new(); // existing database

var artist = new Artist { FirstName = "Abdelghany", LastName = "Hafez" };

var cover = new Cover { DesignIdeas = "What is?" };

artist.Covers.Add(cover);

_context.Artists.Add(artist);

_context.SaveChanges();
