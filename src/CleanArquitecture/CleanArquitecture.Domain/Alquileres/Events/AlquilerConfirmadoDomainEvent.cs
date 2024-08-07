namespace CleanArquitecture.Domain;

public sealed record AlquilerConfirmadoDomainEvent(Guid AlquilerId) : IDomainEvent;
