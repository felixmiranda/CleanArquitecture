
namespace CleanArquitecture.Domain;

public sealed class Alquiler : Entity
{
    public Alquiler(Guid id) : base(id)
    {
    }

    public AlquilerStatus Status { get; private set; }

}
