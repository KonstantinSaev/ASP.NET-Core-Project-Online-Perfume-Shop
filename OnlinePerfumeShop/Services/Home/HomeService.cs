﻿using OnlinePerfumeShop.Data;
using OnlinePerfumeShop.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePerfumeShop.Services.Home
{
    public class HomeService : IHomeService
    {
        private readonly OnlinePerfumeShopDbContext dbContext;

        public HomeService(OnlinePerfumeShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<ListPerfumesServiceModel> All(int page, int itemsPerPage)
        {
            return dbContext.Perfumes
                .OrderBy(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(x => new ListPerfumesServiceModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImgUrl = x.ImageUrl,
                    Quantity = x.Qunatity,
                }).ToList();
        }
        public int GetCount()
        {
            return dbContext.Perfumes.Count();
        }
    }
}