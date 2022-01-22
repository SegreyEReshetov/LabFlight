using System;
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
    public class ServiceClassRepository : AbstractRepository<ServiceClass, int>, IServiceClassRepository
    {
        public ServiceClassRepository(Context context)
        {
            _context = context;
        }
        #region implementation
        protected override int KeySelector(ServiceClass entity) => entity.Id;
        protected override ServiceClass ReadImplementation(int key)
        {
            return QueryImplementation().FirstOrDefault(i => i.Id == key);
        }
        protected override async Task<ServiceClass> ReadImplementationAsync(int key)
        {
            return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
        }
        protected override void CreateImplementation(ServiceClass value)
        {
            _context.ServiceClasses.Add(value);
        }
        protected override async Task CreateImplementationAsync(ServiceClass value)
        {
            await _context.ServiceClasses.AddAsync(value);
        }
        protected override void UpdateImplementation(ServiceClass entity, ServiceClass value)
        {
            _context.ChangeTracker.Clear();
            _context.Update(value);
        }
        protected override void DeleteImplementation(ServiceClass value)
        {
            var entity = ReadImplementation(value.Id);
            if (entity == null) return;
            _context.ServiceClasses.Remove(entity);
        }
        protected override IQueryable<ServiceClass> QueryImplementation()
        {
            return _context.ServiceClasses
                 .Include(serviceClasss => serviceClasss.Seats);
        }
        #endregion
    }
}
