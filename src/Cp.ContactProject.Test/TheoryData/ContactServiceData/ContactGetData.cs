using Cp.ContactService.Protos;

namespace Cp.ContactProject.Test.TheoryData.ContactServiceData
{
    public class ContactGetData : TheoryData<IEnumerable<ContactModel>>
    {
        public ContactGetData()
        {
            var list = new List<ContactModel>()
            {
                new ContactModel()
                {
                    UUID = 1,
                    Ad = "Ayşe",
                    Soyad = "Çiçek",
                    Firma = "Company One"
                },new ContactModel()
                {
                    UUID = 2,
                    Ad = "Ali",
                    Soyad = "Böcek",
                    Firma = "Company One"
                },
                new ContactModel()
                {
                    UUID = 3,
                    Ad = "Murat",
                    Soyad = "Ağaç",
                    Firma = "Company Two"
                },
                new ContactModel()
                {
                    UUID = 4,
                    Ad = "Bahar",
                    Soyad = "Yeni",
                    Firma = "Company Two"
                },
                new ContactModel()
                {
                    UUID = 5,
                    Ad = "Fatma",
                    Soyad = "Öz",
                    Firma = "Company Three"
                }
            };

            Add(list);
        }
    }
}
