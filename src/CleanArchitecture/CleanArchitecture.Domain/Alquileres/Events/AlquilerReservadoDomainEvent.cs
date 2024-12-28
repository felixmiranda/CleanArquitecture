using CleanArchitecture.Domain.Abstractions;
using MediatR;

namespace CleanArchitecture.Domain.Alquileres.Events;

public sealed record AlquilerReservadoDomainEvent(Guid AlquilerId) : IDomainEvent;

