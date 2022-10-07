using Cp.ContactService.Protos;

namespace Cp.ContactProject.Test.TheoryData.ContactServiceData
{
    public class ContactCreateData : TheoryData<ContactModel>
    {
        public ContactCreateData()
        {
            Add(new ContactModel()
            {
                Ad = "Kaan",
                Soyad = "Aslan",
                Firma = "Company One"
            });
            Add(new ContactModel()
            {
                Ad = "Elif",
                Soyad = "Düzgün",
                Firma = "Company One"
            });
            Add(new ContactModel()
            {
                Ad = "Berk",
                Soyad = "Aydın",
                Firma = "Company Two"
            });
            Add(new ContactModel()
            {
                Ad = "Ece",
                Soyad = "Kalın",
                Firma = "Company Two"
            });
            Add(new ContactModel()
            {
                Ad = "Yunus Ali",
                Soyad = "Tez",
                Firma = "Company Three"
            });
        }
    }
}
