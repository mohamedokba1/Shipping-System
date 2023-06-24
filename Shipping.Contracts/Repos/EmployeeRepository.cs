﻿using Microsoft.EntityFrameworkCore;
using Shipping.Entities;
using Shipping.Entities.Domain.Models;
using Shipping.Repositories.Contracts;


namespace Shipping.Repositories.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;
        
        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async  Task Add(Employee employee)
        {
           await  context.Employees.AddAsync(employee);
        }         

        public async Task Delete(long id)
        {
            var employee = await GetByid(id);
        }

        public async Task<IEnumerable<Employee>> Getall()
        {
             return await context.Employees.Include(e=>e.Branch).Include(e=>e.User).ToListAsync();

        }

        public async Task<Employee?> GetByid(long id)
        {
            return await context.Set<Employee>().Include(e=>e.Branch).Include(e=>e.User).FirstOrDefaultAsync(e => e.EmployeeId == id);
        }

        public async Task Savechanges()
        {
            await context.SaveChangesAsync();
        }

        public async Task Update(long id, Employee? employee)
        {

        }
    }
}
