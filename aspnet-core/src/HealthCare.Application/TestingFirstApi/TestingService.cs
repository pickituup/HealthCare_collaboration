using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.TestingFirstApi {
    public class TestingService : HealthCareAppServiceBase, ITestingService {

        private readonly MessageManager _messageManager;

        /// <summary>
        ///     ctor().
        /// </summary>
        public TestingService(MessageManager messageManager) {
            _messageManager = messageManager;
        }

        public async Task<string> GetMessage() {
            return await _messageManager.GetGreetingAsync();
        }
    }
}
