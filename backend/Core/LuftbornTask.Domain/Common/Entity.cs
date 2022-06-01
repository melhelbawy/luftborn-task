using LuftbornTask.Domain.Interfaces;

namespace LuftbornTask.Domain.Common;

public abstract class Entity : Entity<Guid>, IEntity
{
}