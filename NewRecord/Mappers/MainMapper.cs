using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRecord.Entities;
using NewRecord.Models;

namespace NewRecord.Mappers
{
    public class MainMapper
    {
        public MainWindowModel Map(MainEntity entity)
        {
            MainWindowModel mainEntity = new MainWindowModel()
            {
                Name = entity.Name,
                Surname = entity.Surname,
                FatherName = entity.FatherName
            };
            return mainEntity;
        }
        public MainEntity Map(MainWindowModel model)
        {
            MainEntity mainModel = new MainEntity()
            {
                Name = model.Name,
                Surname = model.Surname,
                FatherName = model.FatherName
            };
            return mainModel;
        }


    }
}
