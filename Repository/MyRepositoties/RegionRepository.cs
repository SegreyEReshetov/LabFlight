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
    public class RegionRepository : AbstractRepository<Region, int>, IRegionRepository
    {
        public RegionRepository(Context context)
        {
            _context = context;
        }
        #region implementation
        protected override int KeySelector(Region entity) => entity.Id;
        protected override Region ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<Region> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(Region value)
        {
            _context.Regions.Add(value);
        }
        protected override async Task CreateImplementationAsync(Region value)
        {
            await _context.Regions.AddAsync(value);
        }
        protected override void UpdateImplementation(Region entity, Region value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(Region value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.Regions.Remove(entity);
        }

        protected override IQueryable<Region> QueryImplementation()
        {
            return _context.Regions
                 .Include(regions => regions.Country);
        }
        #endregion
    }
}
