namespace dailyquiz.Domain.Entities;

public class Vote : BaseAuditableEntity 
{
    public bool Upvote { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; }
    public Guid QuestionId {get;set;}
    public required Question Question {get; set;}
}