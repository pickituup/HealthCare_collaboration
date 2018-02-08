using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using HealthCare.EntityFrameworkCore;
using HealthCare.EntityFrameworkCore.Repositories;
using HealthCare.Messages;

namespace HealthCare.TestingFirstApi {
    public class MessageData : HealthCareRepositoryBase<Message, long>, IMessageData {
        private readonly IDbContextProvider<HealthCareDbContext> _dbContextProvider;

        public MessageData(IDbContextProvider<HealthCareDbContext> dbContextProvider)
        : base(dbContextProvider) {
            _dbContextProvider = dbContextProvider;
        }

        public Message GetMessage() {
            return _dbContextProvider.GetDbContext().Messages.First();
        }
    }
}
