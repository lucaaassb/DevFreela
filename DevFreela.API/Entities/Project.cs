using DevFreela.API.Controllers;
using DevFreela.API.Enums;

namespace DevFreela.API.Entities;

public class Project : BaseEntity
{
    protected Project() { }
    public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)
        : base()
    {
        Title = title;
        Description = description;
        IdClient = idClient;
        IdFreelancer = idFreelancer;
        TotalCost = totalCost;

        Status = ProjectsControllerEnum.Created;
        Comments = [];
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public int IdClient { get; private set; }
    public User Client { get; private set; }
    public int IdFreelancer { get; private set; }
    public User Freelancer { get; private set; }
    public decimal TotalCost { get; private set; }
    public DateTime? StartedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }
    public ProjectsControllerEnum Status { get; private set; }
    public List<ProjectComment> Comments { get; private set; }

    public void Cancel()
    {
        if (Status == ProjectsControllerEnum.InProgress || Status == ProjectsControllerEnum.Suspended)
        {
            Status = ProjectsControllerEnum.Cancelled;
        }
    }

    public void Start()
    {
        if (Status == ProjectsControllerEnum.Created)
        {
            Status = ProjectsControllerEnum.InProgress;
            StartedAt = DateTime.Now;
        }
    }

    public void Complete()
    {
        if (Status == ProjectsControllerEnum.PaymentPending || Status == ProjectsControllerEnum.InProgress)
        {
            Status = ProjectsControllerEnum.Completed;
            CompletedAt = DateTime.Now;
        }
    }

    public void SetPaymentPending()
    {
        if (Status == ProjectsControllerEnum.InProgress)
        {
            Status = ProjectsControllerEnum.PaymentPending;
        }
    }

    public void Update(string tittle, string description, decimal totalCost)
    {
        Title = tittle;
        Description = description;
        TotalCost = totalCost;
    }
}