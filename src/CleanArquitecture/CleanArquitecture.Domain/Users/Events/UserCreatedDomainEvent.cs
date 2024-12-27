namespace CleanArchitecture.Domain;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent
{

}
