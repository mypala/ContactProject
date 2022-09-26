using Cp.ContactService.Protos;

namespace Cp.ContactService.Data.Repositories
{
    public interface IContactRepository
    {
        Task<ContactModel> Get(long contactId);
        Task<IEnumerable<ContactModel>> GetAll();
        Task<ContactModel> Create(ContactModel contact);
        Task<ContactModel> Update(ContactModel contact);
        Task<Response> Delete(long id);
    }
}
