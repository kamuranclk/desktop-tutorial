using Core.Entity;
using Core.IRepository;
using Core.IUnitOfWork;
using Manager.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Service
{
    public class ProductyService : Service<Product>, IProductService
    {
        public ProductyService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }
    }
}
