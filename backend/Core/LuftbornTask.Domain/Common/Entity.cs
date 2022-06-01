namespace LuftbornTask.Domain.Common;

using LuftbornTask.Domain.Interfaces;

    public class Entity : IEntity<TKey>
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

        public void SetIsActive(bool isActive)
        {
            InactiveDate = isActive ? null : DateTime.Now;
        }
    }

    public class Entity : IEntity<Guid>, IEntity {}
