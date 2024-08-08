namespace CleanArchitecture.Domain;

public static class ReviewErrors
{
    public static readonly Error NotEligible = new(
        "Review.NotEligible",
        "Este review y calificacion para el auto no es elegible porque aun no se completa"
    );
}
