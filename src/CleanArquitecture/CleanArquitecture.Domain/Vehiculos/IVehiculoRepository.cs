namespace CleanArquitecture.Domain;

public interface IVehiculoRepository
{
    Task<Vehiculo> GetByIdAsync(Guid id, CancellationToken cancellationToken = default(CancellationToken));
}
