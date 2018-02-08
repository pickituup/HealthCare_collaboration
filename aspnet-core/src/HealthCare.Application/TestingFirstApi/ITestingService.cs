using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.TestingFirstApi {
    public interface ITestingService : IApplicationService {
        Task<string> GetMessage();
    }
}
