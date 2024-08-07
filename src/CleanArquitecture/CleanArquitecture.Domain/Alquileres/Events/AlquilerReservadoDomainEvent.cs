namespace CleanArquitecture.Domain;

public sealed record AlquilerReservadoDomainEvent(Guid AlquilerId) : IDomainEvent;

