namespace CleanArchitecture.Domain;

public sealed record AlquilerReservadoDomainEvent(Guid AlquilerId) : IDomainEvent;

