﻿using Shipping.Entities.Models;
using System.Net.Sockets;

namespace Shipping.Repositories.Contracts;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllAsync();
    Task<Customer>? GetByIdAsync(int id);
    Task AddAsync(Customer entity);
    Task UpdateAsync(Customer entity);
    Task DeleteAsync(Customer entity);
    Task SaveChangesAsync();
}
