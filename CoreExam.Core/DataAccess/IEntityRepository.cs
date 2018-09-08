using CoreExam.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreExam.Core.DataAccess
{
    public interface IEntityRepository <T> where T:class, IEntity, new()
    {
    }
}
