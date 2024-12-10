using QLKTX.Domains.Entities;

namespace QLKTX.Domains.Interface
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
    }

    public interface IInvoiceDetailRepository : IBaseRepository<InvoiceDetail>
    {
    }
}
