﻿using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMenuService
    {
        List<Menu> GetAll();
        string BuildMenu(List<Menu> menus);
    }
}
