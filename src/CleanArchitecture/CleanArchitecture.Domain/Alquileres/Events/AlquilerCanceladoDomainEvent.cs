namespace CleanArchitecture.Domain;

public sealed record AlquilerCanceladoDomainEvent(Guid AlquilerId) : IDomainEvent;
