using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Entities;
using MyCosmetologist.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Data.Repositories
{
    public class RecordRepository : BaseRepository<Record>, IRecordRepository
    {
        public RecordRepository (IContextFactory factory) : base(factory.GetContext())
        { }
    }
}
