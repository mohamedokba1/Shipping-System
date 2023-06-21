﻿using Shipping.Entities.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace Shipping.Repositories;


public interface IBranchRepository
    {
        Task<IEnumerable<Branch>> GetAllAsync();
        Task<Branch?> GetByIdAsync(int id);
        Task AddAsync(Branch entity);
        Task UpdateAsync(Branch entity);
        Task DeleteAsync(Branch entity);
        Task SaveChangesAsync();
    Task<IEnumerable<Branch?>> GetRange(List<int> ids);
}