using Cp.ContactInformationService.Data.Repositories;
using Cp.ContactInformationService.Protos;
using Grpc.Core;
using static Cp.ContactInformationService.Protos.ContactInformationService;

namespace Cp.ContactInformationService.Services
{
    public class ContactInformationService : ContactInformationServiceBase
    {
        private readonly ILogger<ContactInformationService> _logger;
        private readonly IContactInformationRepository _repository;
        
        public ContactInformationService(IContactInformationRepository repository, ILogger<ContactInformationService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public override async Task<ContactInformation> Get(InformationId request, ServerCallContext context)
        {
            return await _repository.Get(request.UUID);
        }

        public override async Task<ListOfInformation> GetAll(GetAllRequest request, ServerCallContext context)
        {
            var response = new ListOfInformation();

            var informations = await _repository.GetAll(request.ContactId);
            response.Informations.AddRange(informations);

            return response;
        }

        public override async Task<ContactInformation> Post(ContactInformation request, ServerCallContext context)
        {
            return await _repository.Create(request);
        }

        public override async Task<ContactInformation> Put(ContactInformation request, ServerCallContext context)
        {
            return await _repository.Update(request);
        }

        public override async Task<Response> Delete(InformationId request, ServerCallContext context)
        {
            return await _repository.Delete(request.UUID);
        }
    }
}