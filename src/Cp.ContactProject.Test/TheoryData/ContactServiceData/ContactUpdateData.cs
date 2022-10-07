using Cp.ContactService.Protos;

namespace Cp.ContactProject.Test.TheoryData.ContactServiceData
{
    public class ContactUpdateData : TheoryData<ContactModel>
    {
        public ContactUpdateData()
        {
            Add(new ContactModel()
            {
                UUID = 1,
                Ad = "Ayşe",
                Firma = "Company Two"
            });
            Add(new ContactModel()
            {
                UUID = 2,
                Soyad = "Böcek",
                Firma = "Company One"
            });
            Add(new ContactModel()
            {
                UUID = 3,
                Firma = "Company Two"
            });
            Add(new ContactModel()
            {
                UUID = 4,
                Ad = "Bahar",
                Soyad = "Yeni",
                Firma = "Company Three"
            });
            Add(new ContactModel()
            {
                UUID = 5,
                Firma = "Company One"
            });
        }
    }
}
