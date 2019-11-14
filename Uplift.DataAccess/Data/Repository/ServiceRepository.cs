using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Service service)
        {
            var srvFromDb = _db.Service.FirstOrDefault(s => s.Id == service.Id);

            srvFromDb.Name = service.Name;
            srvFromDb.LongDesc = service.LongDesc;
            srvFromDb.Price = service.Price;
            srvFromDb.ImageUrl = service.ImageUrl;
            srvFromDb.FrequencyId = service.FrequencyId;
            srvFromDb.CategoryId = service.CategoryId;

            _db.SaveChanges();
        }
    }
}
