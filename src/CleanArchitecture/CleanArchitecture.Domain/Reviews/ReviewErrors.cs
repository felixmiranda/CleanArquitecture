using System;
using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Reviews;

public static class ReviewErrors
{
    public static readonly Error NotElegible = new(
        "Review.NotElegible",
        "El alquiler no es elegible para crear una reseña"
    );
}
