using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;//Bu olmazsa Include() çalışmaz
using System.Text;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMenuDal : EfEntityRepositoryBase<Menu, NorthwindContext>, IMenuDal
    {
    }
}
