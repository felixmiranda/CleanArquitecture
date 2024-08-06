namespace CleanArquitecture.Domain;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent
{

}
