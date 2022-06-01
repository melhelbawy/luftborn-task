using LuftbornTask.Domain.Common;
using LuftbornTask.Domain.Interfaces;

namespace LuftbornTask.Domain.Entities.BookAggregate;
public class Author : Entity, IAggregateRoot
{
    public string AuthorName { get; set; }

    public ICollection<Book> Books { get; set; }

}
