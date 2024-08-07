namespace CleanArquitecture.Domain;

public sealed record AlquilerCompletadoDomainEvent(Guid AlquilerId) : IDomainEvent;
