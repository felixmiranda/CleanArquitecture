namespace CleanArchitecture.Domain;

public sealed record AlquilerCompletadoDomainEvent(Guid AlquilerId) : IDomainEvent;
