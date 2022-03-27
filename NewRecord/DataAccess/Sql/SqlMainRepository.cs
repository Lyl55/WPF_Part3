using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRecord.Abstract;
using NewRecord.Entities;

namespace NewRecord.DataAccess.Sql
{
    public class SqlMainRepository:IMainRepository
    {
        public void Add(MainEntity entity)
        {
            //code
        }

        public List<MainEntity> Get()
        {
            return new List<MainEntity>()
            {
                new MainEntity(){Name = "Jack",Surname = "Copperfield",FatherName = "Leo"}
            };
        }
    }
}
