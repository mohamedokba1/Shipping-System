﻿using System.Net.Sockets;
using Shipping.Entities.Models;

namespace Shipping.Repositories;

public interface ICityRepository
{
    Task<IEnumerable<City>> GetAllAsync();
    Task<City> GetByIdAsync(int id);
    Task AddAsync(City entity);
    Task UpdateAsync(City entity);
    Task DeleteAsync(City entity);
    Task SaveChangesAsync();
}