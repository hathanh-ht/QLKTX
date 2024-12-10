using QLKTX.Domains.Entities;
using QLKTX.Domains.Interface;

namespace QLKTX.Infras.Repository
{
    public class UserRepository : BaseRepository<UserAccount>, IUserRepository
    {
        public UserRepository(DormitoryContext context) : base(context)
        {
        }
    }
}
