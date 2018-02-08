using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HealthCare.Messages;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCare.TestingFirstApi {
    public class MessageManager : DomainService {
        private readonly IRepository<Message, long> _messageRepository;

        /// <summary>
        ///     ctor.
        /// </summary>
        public MessageManager(IRepository<Message, long> messageRepository) {
            _messageRepository = messageRepository;
        }

        public async Task<string> GetGreetingAsync() {
            string greeting = string.Empty;
            await Task.Run(() => {
                greeting = "Greeting";
            });
            return greeting;
        }
    }
}