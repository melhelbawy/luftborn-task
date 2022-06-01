using LuftbornTask.Domain.Interfaces;

namespace LuftbornTask.Domain.Common;
public abstract class Entity<TKey> : IEntity<TKey>
{
    protected Entity()
    {
        HandleGuidPrimaryKeyGeneration();

    }

    public TKey Id { get; set; }

    public DateTime CreationDate { get; protected set; }

    public DateTime? InactiveDate { get; protected set; }

    public bool IsActive => InactiveDate == null;

    private void HandleGuidPrimaryKeyGeneration()
    {
        if (typeof(TKey) == typeof(Guid))
        {
            GetType().GetProperty(nameof(Id)).SetValue(this, Guid.NewGuid());
        }
    }

}

