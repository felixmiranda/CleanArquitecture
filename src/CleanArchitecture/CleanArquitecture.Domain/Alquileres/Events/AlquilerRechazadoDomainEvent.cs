namespace CleanArchitecture.Domain;

public sealed record AlquilerRechazadoDomainEvent(Guid AlquilerId) : IDomainEvent;
