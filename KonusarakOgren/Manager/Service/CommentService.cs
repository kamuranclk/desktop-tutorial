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
    public class commentService : Service<Comment>, ICommentService
    {
        public commentService(IUnitOfWork unitOfWork, IRepository<Comment> repository) : base(unitOfWork, repository)
        {
        }
    }
}
