﻿using HouseRentingSystem.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using MoneyManager.Core.Contracts;
using MoneyManager.Core.Models.CategoryIncome;
using MoneyManager.Infrastructure.Data.Entities;

namespace MoneyManager.Core.Services
{
    public class CategoryIncomeService : ICategoryIncomeService
    {
        private readonly IRepository repo;
        public CategoryIncomeService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<bool> AddCategoryAsync(AddCategoryIncomeViewModel model)
        {
            var allCategories = await repo.AllReadonly<CategoryIncome>().ToListAsync();

            if (!allCategories.Any(x => x.Name.ToLower() == model.Name.ToLower()))
            {
                var entity = new CategoryIncome()
                {
                    Name = model.Name
                };

                await repo.AddAsync(entity);

                await repo.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task EditAsync(EditCategoryIncomeViewModel model)
        {
            var entity = await repo.GetByIdAsync<CategoryIncome>(model.Id);


            entity.Name = model.Name;

            await repo.SaveChangesAsync();
        }

        public async Task<List<CategoryIncomeViewModel>> GetAllAsync()
        {
            return await repo.AllReadonly<CategoryIncome>().OrderBy(x => x.Name).Select(i => new CategoryIncomeViewModel()
            {
                Id = i.Id,
                Name = i.Name
            }).ToListAsync();
        }

        public async Task<EditCategoryIncomeViewModel> GetForEditAsync(Guid id)
        {
            var category = await repo.GetByIdAsync<CategoryIncome>(id);

            return new EditCategoryIncomeViewModel()
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}