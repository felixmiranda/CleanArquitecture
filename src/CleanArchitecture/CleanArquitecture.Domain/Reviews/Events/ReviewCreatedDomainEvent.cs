namespace CleanArchitecture.Domain;

public sealed record ReviewCreatedDomainEvent(Guid AlquilerId) : IDomainEvent;

