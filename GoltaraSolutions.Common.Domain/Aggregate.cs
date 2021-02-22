namespace GoltaraSolutions.Common.Domain
{
    public abstract class Aggregate : IEntity
    {
        public long Id { get;  set; }
        public bool Deletado { get;  set; }
    }
    public interface IEntity
    {
        long Id { get; }
    }
}
