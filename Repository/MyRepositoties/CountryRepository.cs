﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.MyEnties;
using Business.MyRepositories;
using Microsoft.EntityFrameworkCore;
using Repository.MyData;

namespace Repository.MyRepositories
{
    public class CountryRepository : AbstractRepository<Country, int>, ICountryRepository
    {
        public CountryRepository(Context context)
        {
            _context = context;
        }

        #region implementation
        protected override int KeySelector(Country entity) => entity.Id;
        protected override Country ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Country> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Country value)
        {
            _context.Countries.Add(value);
        }
        protected override async Task CreateImplementationAsync(Country value)
        {
            await _context.Countries.AddAsync(value);
        }
        protected override void UpdateImplementation(Country entity, Country value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Country value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Countries.Remove(entity);
        }

        protected override IQueryable<Country> QueryImplementation()
        {
            return null;
                             
                        
         }
        #endregion
    }
}
