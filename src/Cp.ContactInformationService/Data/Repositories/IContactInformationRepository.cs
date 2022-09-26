using Cp.ContactInformationService.Protos;

namespace Cp.ContactInformationService.Data.Repositories
{
    public interface IContactInformationRepository
    {
        Task<ContactInformation> Get(long contactId);
        Task<IEnumerable<ContactInformation>> GetAll(long contactId);
        Task<ContactInformation> Create(ContactInformation contactInformation);
        Task<ContactInformation> Update(ContactInformation contactInformation);
        Task<Response> Delete(long id);
    }
}
