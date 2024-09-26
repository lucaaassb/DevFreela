namespace DevFreela.API.Entities;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        CreatedAt = DateTime.Now;
        isDeleted = false;
    }
    
    public int Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool isDeleted { get; private set; }

    public void SetAsDeleted()
    {
        isDeleted = true;
    }
}