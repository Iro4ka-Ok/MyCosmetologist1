using Microsoft.EntityFrameworkCore;

namespace MyCosmetologist.Data.Core.Interfaces
{
    public interface IContextFactory
    {
        DbContext GetContext();
    }
}