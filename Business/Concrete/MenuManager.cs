using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class MenuManager : IMenuService
    {
        private IMenuDal _menuDal;
        private List<int?> _takenIds;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
            _takenIds = new List<int?>();
        }
        public string BuildMenu(List<Menu> menus)
        {
            var map = "";
            if (menus.Count > 0)
            {
                map += "<ul>";
                foreach (var menu in menus)
                {
                    if (!_takenIds.Contains(menu.Id))
                    {
                        map += "<li>" + menu.Name;
                        List<Menu> subMenus = _menuDal.GetAll().Where(c => c.ParentId == menu.Id).ToList();
                        map += BuildMenu(subMenus);
                        map += "</li>";
                    }
                    _takenIds.Add(menu.Id);
                }
                map += "</ul>";
            }
            return map;
        }
        public List<Menu> GetAll()
        {
            return _menuDal.GetAll();
        }
    }
}
