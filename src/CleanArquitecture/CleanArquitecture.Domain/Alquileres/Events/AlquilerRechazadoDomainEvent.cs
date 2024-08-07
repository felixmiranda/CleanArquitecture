namespace CleanArquitecture.Domain;

public sealed record AlquilerRechazadoDomainEvent(Guid AlquilerId) : IDomainEvent;
