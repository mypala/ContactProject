using Cp.ContactService.Data.Repositories;
using Cp.ContactService.Protos;
using Grpc.Core;
using static Cp.ContactService.Protos.ContactService;

namespace Cp.ContactService.Services
{
    public class ContactService : ContactServiceBase
    {
        private readonly ILogger<ContactService> _logger;
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository, ILogger<ContactService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public override async Task<ContactModel> Get(ContactId request, ServerCallContext context)
        {
            return await _repository.Get(request.UUID);
        }

        public override async Task<ListOfContact> GetAll(Empty request, ServerCallContext context)
        {
            var response = new ListOfContact();

            var informations = await _repository.GetAll();
            response.Contacts.AddRange(informations);

            return response;
        }

        public override async Task<ContactModel> Post(ContactModel request, ServerCallContext context)
        {
            return await _repository.Create(request);
        }

        public override async Task<ContactModel> Put(ContactModel request, ServerCallContext context)
        {
            return await _repository.Update(request);
        }

        public override async Task<Response> Delete(ContactId request, ServerCallContext context)
        {
            return await _repository.Delete(request.UUID);
        }
    }
}
