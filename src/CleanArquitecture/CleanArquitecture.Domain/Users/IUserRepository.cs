﻿namespace CleanArquitecture.Domain;

public interface IUserRepository
{
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(User user);
}
