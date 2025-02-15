﻿using BootCoinApp.Data;
using BootCoinApp.Interfaces;
using BootCoinApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCoinApp.Repository
{
    public class CategoryRewardRepository : ICategoryRewardRepository
    {
        private readonly AppDbContext _context;

        public CategoryRewardRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Add(CategoryReward categoryReward)
        {
            _context.Add(categoryReward);
            return Save();
        }

        public bool Delete(CategoryReward categoryReward)
        {
            _context.Remove(categoryReward);
            return Save();
        }

        public async Task<IEnumerable<CategoryReward>> GetAll(string query = "")
        {
            IEnumerable<CategoryReward> categoryRewards = await _context.CategoryRewards.Include(cr => cr.Rewards).ToListAsync();
            if (!string.IsNullOrEmpty(query))
            {
                categoryRewards = categoryRewards.Where(cr => cr.Name.ToLower().Contains(query.ToLower()));
            }
            return categoryRewards;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(CategoryReward categoryReward)
        {
            _context.Update(categoryReward);
            return Save();
        }
    }
}
