using Cp.ContactInformationService.Data.Context;
using Cp.ContactInformationService.Protos;

namespace Cp.ContactInformationService.Data.Repositories
{
    public class ContactInformationRepository : IContactInformationRepository
    {
        private readonly ContactInformationContext _context;
        public ContactInformationRepository(ContactInformationContext context)
        {
            _context = context;
        }

        public async Task<ContactInformation> Get(long uuid)
        {
            return _context.ContactInformations.FirstOrDefault(x => x.UUID == uuid);
        }

        public async Task<IEnumerable<ContactInformation>> GetAll(long contactId)
        {
            return _context.ContactInformations.Where(x => x.ContactId == contactId);
        }

        public async Task<ContactInformation> Create(ContactInformation contactInformation)
        {
            var result = await _context.ContactInformations.AddAsync(contactInformation);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ContactInformation> Update(ContactInformation contactInformation)
        {
            var result = _context.ContactInformations.Update(contactInformation);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Response> Delete(long id)
        {
            Response result;
            
            try
            {
                _context.ContactInformations.Remove(new ContactInformation() { UUID = id });
                await _context.SaveChangesAsync();
                result = new Response()
                {
                    Code = 200,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                if (_context.ContactInformations.Any(i => i.UUID != id))
                {
                    result = new Response()
                    {
                        Code = 404,
                        Message = "Success"
                    };
                }
                else
                {
                    result = new Response()
                    {
                        Code = 400,
                        Message = ex.ToString()
                    };
                }
            }

            return result;
        }
    }
}
