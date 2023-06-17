﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shipping.Entities;
using Shipping.Entities.Domain.Identity;
using Shipping.Entities.Domain.Models;
using Shipping.Repositories.Contracts;

namespace Shipping.Repositories.Repos;

public class TraderRepository : ITraderRepository
{
    private readonly ApplicationDbContext _context;
    public TraderRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
    }
    public async Task<Trader?> AddTraderAsync(Trader trader)
    {
        _context.Set<Trader>().Add(trader);
        int result = await _context.SaveChangesAsync();
        if(result == 1)
            return trader;
        return null;
    }

    public async Task DeleteTraderAsync(Trader trader)
    {
        _context.Set<Trader>().RemoveRange(trader);
        await SaveChangesAsync();
    }

    public async Task<IEnumerable<Trader>> GetAllTradersAsync()
    {
        return await _context.Set<Trader>().ToListAsync();
    }
    public async Task<Trader?> GetTraderByIdAsync(string trader_id)
    {
        return await _context.Set<Trader>().FirstOrDefaultAsync(temp => temp.User.Id == trader_id);
    }
    public async Task<Trader?> GetByEmailAsync(string email)
    {
        return _context.Set<Trader>()
            .Include(sr => sr.User)
            .FirstOrDefault(sr => sr.User.Email == email);
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Trader trader)
    {
        _context.Set<Trader>().Update(trader);
        await Task.CompletedTask;
    }

    public IQueryable<Trader> GetTradersPaginated()
    {
        return _context.Set<Trader>().AsQueryable();
    }

    public async Task<IEnumerable<Trader>> GetFilteredTradersAsync(string searchSrting)
    {
        return await _context.Set<Trader>().Where(trader => trader.User.UserName.Contains(searchSrting)).ToListAsync();
    }
}
