using Cp.ContactProject.Test.TheoryData.ContactServiceData;
using Cp.ContactService.Protos;
using GrpcContactService = Cp.ContactService.Services.ContactService;

namespace Cp.ContactProject.Test.UnitTests
{
    public class ContactServiceTest : IClassFixture<GrpcContactService>
    {
        GrpcContactService _contactService;
        public ContactServiceTest(GrpcContactService contactService)
        {
            _contactService = contactService;
        }
    }
}
