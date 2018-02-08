using Abp.Domain.Repositories;
using HealthCare.Messages;
using System.Collections.Generic;

namespace HealthCare.TestingFirstApi {
    public interface IMessageData : IRepository<Message,long> {
        Message GetMessage();
    }
}