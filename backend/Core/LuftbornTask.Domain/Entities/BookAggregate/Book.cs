
namespace LuftbornTask.Domain.Entities.BookAggregate;

using LuftbornTask.Domain.Common;
using LuftbornTask.Domain.Interfaces;


public class Book : Entity, IAggregateRoot
{
    public string BookTitle { get; set; }

    public string BookSummary { get; set; }

    public decimal BookPrice { get; set; }

    public Guid AuthorId { get; set; }

    public Author Author { get; set; }
}
