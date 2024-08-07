namespace CleanArquitecture.Domain;

public sealed record AlquilerCanceladoDomainEvent(Guid AlquilerId) : IDomainEvent;
