using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRecord.Entities;

namespace NewRecord.Abstract
{
    public interface IMainRepository
    {
        void Add(MainEntity entity);
        List<MainEntity> Get();
    }
}
