using Cp.ContactProject.Test.TheoryData.ContactServiceData;
using Cp.ContactService.Data.Repositories;
using Cp.ContactService.Protos;

namespace Cp.ContactProject.Test.UnitTests
{
    public class ContactRepositoryTest //: IClassFixture<IContactRepository>
    {
        private readonly IContactRepository _repository;

        public ContactRepositoryTest(IContactRepository contactRepository)
        {
            _repository = contactRepository;
        }

        [Theory]
        [ClassData(typeof(ContactCreateData))]
        public async void CreateTest(ContactModel contact)
        {
            #region Act
            var result = await _repository.Create(contact);
            #endregion
            #region Assert
            Assert.Equal(contact, new ContactModel() { Ad = result.Ad, Soyad = result.Soyad, Firma = result.Firma });
            #endregion
        }
    }
}
