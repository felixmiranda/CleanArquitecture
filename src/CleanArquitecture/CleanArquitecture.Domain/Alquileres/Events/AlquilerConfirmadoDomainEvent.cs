namespace CleanArchitecture.Domain;

public sealed record AlquilerConfirmadoDomainEvent(Guid AlquilerId) : IDomainEvent;
