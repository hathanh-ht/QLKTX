using QLKTX.Domains.Entities;
using QLKTX.Domains.Interface;

namespace QLKTX.Infras.Repository
{
    internal class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(DormitoryContext context) : base(context)
        {
        }
    }

    internal class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(DormitoryContext context) : base(context)
        {
        }
    }

    internal class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DormitoryContext context) : base(context)
        {
        }
    }

    internal class InvoiceDetailRepository : BaseRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(DormitoryContext context) : base(context)
        {
        }
    }
}
