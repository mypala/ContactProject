using Cp.ContactService.Data.Context;
using Cp.ContactService.Protos;

namespace Cp.ContactService.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactContext _context;
        public ContactRepository(ContactContext context)
        {
            _context = context;
        }

        public async Task<ContactModel> Get(long uuid)
        {
            return _context.Contacts.FirstOrDefault(x => x.UUID == uuid);
        }

        public async Task<ContactModel> GetLast()
        {
            return _context.Contacts.LastOrDefault();
        }

        public async Task<IEnumerable<ContactModel>> GetAll()
        {
            return _context.Contacts;
        }

        public async Task<ContactModel> Create(ContactModel contact)
        {
            var result = await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ContactModel> Update(ContactModel contact)
        {
            var result = _context.Contacts.Update(contact);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Response> Delete(long id)
        {
            Response result;

            try
            {
                _context.Contacts.Remove(new ContactModel() { UUID = id });
                await _context.SaveChangesAsync();
                result = new Response()
                {
                    Code = 200,
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                if (_context.Contacts.Any(i => i.UUID != id))
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
